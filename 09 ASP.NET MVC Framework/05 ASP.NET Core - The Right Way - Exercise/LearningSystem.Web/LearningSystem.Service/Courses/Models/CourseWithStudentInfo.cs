using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Service.Courses.Models
{
    public class CourseWithStudentInfo
    {
        public DateTime StartDate { get; set; }

        public bool UserIsEnrolledInCourse { get; set; }
    }
}
