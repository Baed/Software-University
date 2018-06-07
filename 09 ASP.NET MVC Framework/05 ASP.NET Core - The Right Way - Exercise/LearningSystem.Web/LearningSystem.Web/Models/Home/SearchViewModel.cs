using LearningSystem.Service.Courses.Models;
using LearningSystem.Service.UserProfile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Web.Models.Home
{
    public class SearchViewModel
    {
        public IEnumerable<CourseListingServiceModel> Courses { get; set; } = new HashSet<CourseListingServiceModel>();

        public IEnumerable<UserListingServiceModel> Users { get; set; } = new HashSet<UserListingServiceModel>();

        public string SearchText { get; set; }
    }
}
