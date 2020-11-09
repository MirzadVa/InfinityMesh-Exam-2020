using Internship_Exam_2020.dal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_Exam_2020.dal.ViewModel
{
    public class BlogDto
    {
        public BlogDto()
        {

        }
        public BlogDto(Blog blog)
        {
            Id = blog.Id;
            Title = blog.Title;
            Summary = blog.Summary;
            Content = blog.Content;
            UserId = blog.UserId;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
    }
}
