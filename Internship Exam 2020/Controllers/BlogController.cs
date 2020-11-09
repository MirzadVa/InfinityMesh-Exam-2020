using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Internship_Exam_2020.dal.Repository;
using Internship_Exam_2020.dal.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Internship_Exam_2020.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BlogController : Controller
    {
        private readonly IBlogRepository _blogRepository;

        public BlogController(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetBlog()
        {
            var blogs = await _blogRepository.GetBlogs();
            return Ok(blogs);
        }
        [HttpPost]
        public async Task<IActionResult> AddBlog([FromBody] BlogDto blog)
        {
            var newBlog = await _blogRepository.AddBlog(blog);
            return Ok(newBlog);
        }

    }
}
