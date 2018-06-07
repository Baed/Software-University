using AutoMapper;
using LearningSystem.Common.Mapping;
using LearningSystem.Constants;
using LearningSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSystem.Service.Blog.Models
{
    public class BlogArticleListingServiceModel : IMapFrom<Article>, ICustomMapperProfile
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime PublishDate { get; set; }

        public string Author { get; set; }

        public void ConfigureMapping(Profile mapper)
        {
            mapper
                .CreateMap<Article, BlogArticleListingServiceModel>()
                .ForMember(a => a.Author, cfq => cfq.MapFrom(a => a.Author.UserName));
        }
    }
}
