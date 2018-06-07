using LearningSystem.Service.Courses.Models;
using LearningSystem.Service.Trainers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Web.Models.Trainers
{
    public class StudentsInCourseViewModel
    {
        public IEnumerable<StudentsInCourseServiceModel> Students { get; set; }

        public CourseListingServiceModel Course { get; set; }
    }
}
