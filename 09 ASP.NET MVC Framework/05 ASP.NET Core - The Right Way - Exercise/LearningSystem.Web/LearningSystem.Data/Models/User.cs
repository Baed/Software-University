using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using LearningSystem.Constants;
using Microsoft.AspNetCore.Identity;

namespace LearningSystem.Data.Models
{
    public class User : IdentityUser
    {
        [Required]
        [MinLength(DataConstants.USER_NAME_MIN_LENGTH)]
        [MaxLength(DataConstants.USER_NAME_MAX_LENGTH)]
        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        public ICollection<Course> Trainings { get; set; } = new HashSet<Course>();

        public ICollection<Article> Articles { get; set; } = new HashSet<Article>();

        public ICollection<StudentCourse> Courses { get; set; } = new HashSet<StudentCourse>();
    }
}
