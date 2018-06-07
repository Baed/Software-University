using AutoMapper;
using LearningSystem.Common.Mapping;
using LearningSystem.Data.Models;
using LearningSystem.Service.Courses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Web.Models.Courses
{
    public class CourseDetailViewModel
    {
        public CourseDetailsServiceModel Course { get; set; }

        public bool UserIsEnrolledCourse { get; set; }
    }
}
