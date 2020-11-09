using Internship_Exam_2020.dal.Context;
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
    public class SQLServerUserRepository : IUserRepository
    {
        private readonly AppDbContext _appDbContext;

        public SQLServerUserRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<UserViewModel> GetFiveUsers(CancellationToken cancellationToken = default)
        {
            const int maxTop = 5;
            var collection = await _appDbContext.Users.Take(maxTop).ToListAsync(cancellationToken);
            return new UserViewModel(collection);
        }

        public async Task<UserViewModel> GetUserProfile(int id, CancellationToken cancellationToken = default)
        {
            var user = await _appDbContext.Users.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
            return new UserViewModel(user);
        }
    }
}
