using LearningSystem.Service.Courses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Web.Models.Home
{
    public class HomeIndexViewModel : SearchFormViewModel
    {
        public IEnumerable<CourseListingServiceModel> Courses { get; set; }

    }
}
