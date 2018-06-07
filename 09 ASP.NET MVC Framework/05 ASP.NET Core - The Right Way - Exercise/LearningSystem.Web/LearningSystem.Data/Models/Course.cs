using LearningSystem.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Data.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        [MinLength(DataConstants.COURSE_NAME_MIN_LENGTH)]
        [MaxLength(DataConstants.COURSE_NAME_MAX_LENGTH)]
        public string Name { get; set; }

        [MaxLength(DataConstants.COURSE_DESCRIPTION_MAX_LENGTH)]
        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
      
        public string TrainerId { get; set; }

        public User Trainer { get; set; }

        public ICollection<StudentCourse> Students { get; set; } = new HashSet<StudentCourse>();
    }
}
