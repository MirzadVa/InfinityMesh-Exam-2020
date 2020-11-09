using Internship_Exam_2020.dal.Context;
using Internship_Exam_2020.dal.Models;
using Internship_Exam_2020.dal.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Internship_Exam_2020.dal.Repository
{
    public class SQLServerBlogRepository : IBlogRepository
    {
        private readonly AppDbContext _appDbContext;

        public SQLServerBlogRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<BlogViewModel> AddBlog(BlogDto blog, CancellationToken cancellationToken = default)
        {
            var blogDomain = new Blog 
            {
                Id = blog.Id,
                Title = blog.Title,
                Summary = blog.Summary,
                Content = blog.Content,
                UserId = blog.UserId
            };
            await _appDbContext.Blogs.AddAsync(blogDomain, cancellationToken);
            await _appDbContext.SaveChangesAsync(cancellationToken);
            return new BlogViewModel(blogDomain);
        }

        public async Task<BlogViewModel> GetAllBlogs(CancellationToken cancellationToken = default)
        {
            const int max = 1000;
            var collection = await _appDbContext.Blogs.Take(max).ToListAsync();
            return new BlogViewModel(collection);
        }

        public async Task<BlogViewModel> GetBlogs(CancellationToken cancellationToken = default)
        {
            const int maxTop = 5;
            var collection = await _appDbContext.Blogs.Take(maxTop).ToListAsync(cancellationToken);
            return new BlogViewModel(collection);
        }


    }
}
