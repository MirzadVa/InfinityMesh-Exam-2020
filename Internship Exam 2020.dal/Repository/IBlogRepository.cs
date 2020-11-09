using Internship_Exam_2020.dal.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Internship_Exam_2020.dal.Repository
{
    public interface IBlogRepository
    {
        Task<BlogViewModel> GetBlogs(CancellationToken cancellationToken = default);
        Task<BlogViewModel> AddBlog(BlogDto blog, CancellationToken cancellationToken = default);
    }
}
