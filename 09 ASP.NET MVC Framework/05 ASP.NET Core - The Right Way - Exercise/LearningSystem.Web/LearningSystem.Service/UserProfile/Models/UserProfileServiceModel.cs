using AutoMapper;
using LearningSystem.Common.Mapping;
using LearningSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Service.UserProfile.Models
{
    public class UserProfileServiceModel : IMapFrom<Course>, ICustomMapperProfile
    {
        public string Username { get; set; }

        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        public IEnumerable<UserProfileCourseServiceModel> Courses { get; set; }

        public void ConfigureMapping(Profile profile)
        {
            profile
                .CreateMap<User, UserProfileServiceModel>()
                .ForMember(u => u.Courses,
                           cfg => cfg.MapFrom(s => s
                                           .Courses
                                           .Select(c => c.Course)));
        }
    }
}
