using Internship_Exam_2020.dal.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Internship_Exam_2020.dal.Repository
{
    public interface IUserRepository
    {
        Task<UserViewModel> GetFiveUsers(CancellationToken cancellationToken = default);
        Task<UserViewModel> GetUserProfile(int id, CancellationToken cancellationToken = default);


    }
}
