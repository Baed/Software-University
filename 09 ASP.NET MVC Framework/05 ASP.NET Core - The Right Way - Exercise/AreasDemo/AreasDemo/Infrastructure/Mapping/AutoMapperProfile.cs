using AreasDemo.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AreasDemo.Infrastructure.Mapping
{
    public class AutoMapperProfile : Profile
    {
      // custom reflection for coupled projects - first way
      //  private readonly string[] Assemblies = new[]
      //  {
      //      "AreasDemo",
      //      "AreasDemo.Services",
      //      "AreasDemo.Data",
      //  };

        public AutoMapperProfile()
        {
            // custom reflection for coupled projects - first way
            //  var typesList = new List<Type>();
            //
            //  foreach (var assemblyName in this.Assemblies)
            //  {
            //      typesList.AddRange(Assembly.Load(assemblyName).GetTypes());
            //  }

            var allTypes = AppDomain
                .CurrentDomain
                .GetAssemblies()
                .Where(a => a.GetName()
                                    .Name
                                    .Contains("AreasDemo"))
                .SelectMany(a => a.GetTypes());

            var mappings = allTypes
                .Where(t => t.IsClass
                         && !t.IsAbstract
                         && t.GetInterfaces()
                                  .Where(i => i.IsGenericType)
                                  .Select(i => i.GetGenericTypeDefinition())
                                  .Contains(typeof(IMapFrom<>)))
                .Select(t => new
                {
                    Destination = t,
                    Source = t
                           .GetInterfaces()
                           .Where(i => i.IsGenericType)
                           .Select(i => new
                           {
                               Definition = i.GetGenericTypeDefinition(),
                               Arguments = i.GetGenericArguments()
                           })
                           .Where(i => i.Definition == typeof(IMapFrom<>))
                           .SelectMany(i => i.Arguments)
                           .First()                   
                })
                .ToList();

            foreach (var mapping in mappings)
            {
                this.CreateMap(mapping.Source, mapping.Destination);
            }

            var customMappings = allTypes
                  .Where(t => t.IsClass 
                           && !t.IsAbstract 
                           && typeof(ICustomMapperProfile).IsAssignableFrom(t))
                  .Select(Activator.CreateInstance)
                  .Cast<ICustomMapperProfile>()
                  .ToList();

            foreach (var custmap in customMappings)
            {
                custmap.ConfigureMapping(this);
            }

            // without reflection
            //  this.CreateMap<ApplicationUser, UserViewModel>()
            //      .ForMember(u => u.MailAdress, cfq => cfq.MapFrom(u => u.Email));
        }   
    }
}
