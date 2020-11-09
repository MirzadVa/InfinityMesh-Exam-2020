using Internship_Exam_2020.dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Internship_Exam_2020.dal.ViewModel
{
    public class BlogViewModel
    {
        public BlogViewModel(Blog blog)
        {
            Blog = new BlogDto(blog);
        }

        public BlogViewModel(IReadOnlyCollection<Blog> blogs)
        {
            Collection = blogs.Select(blog => new BlogDto(blog)).ToList();
        }
        public IReadOnlyCollection<BlogDto> Collection { get; }

        public BlogDto Blog { get; set; }
    }
}
