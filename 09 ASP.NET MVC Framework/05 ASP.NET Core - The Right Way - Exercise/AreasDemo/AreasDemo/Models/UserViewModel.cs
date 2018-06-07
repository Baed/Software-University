using AreasDemo.Infrastructure.Mapping;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasDemo.Models
{
    public class UserViewModel : IMapFrom<ApplicationUser>, ICustomMapperProfile
    {
        public string Id { get; set; }

        public string Username { get; set; }

        public string MailAdress { get; set; }

        public void ConfigureMapping(Profile profile)
           => profile
                 .CreateMap<ApplicationUser, UserViewModel>()
                 .ForMember(u => u.MailAdress, cfq => cfq.MapFrom(u => u.Email));
    }
}
