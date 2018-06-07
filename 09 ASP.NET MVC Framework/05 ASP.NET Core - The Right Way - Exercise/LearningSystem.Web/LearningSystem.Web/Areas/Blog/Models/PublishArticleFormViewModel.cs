using LearningSystem.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Web.Areas.Blog.Models
{  
    public class PublishArticleFormViewModel
    {
        [Required]
        [MinLength(DataConstants.ARTICLE_TITLE_MIN_LENGTH)]
        [MaxLength(DataConstants.ARTICLE_TITLE_MAX_LENGTH)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [DataType(DataType.Date)]
        public DataType PublishDate { get; set; }
    }
}
