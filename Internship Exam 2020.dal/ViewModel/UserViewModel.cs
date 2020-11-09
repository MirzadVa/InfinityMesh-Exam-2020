using Internship_Exam_2020.dal.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Internship_Exam_2020.dal.ViewModel
{
    public class UserViewModel
    {
        public UserViewModel(User user)
        {
            User = new UserDto(user);
        }
        public UserViewModel(IReadOnlyCollection<User> users)
        {
            Collection = users.Select(user => new UserDto(user)).ToList();
        }
        public IReadOnlyCollection<UserDto> Collection { get; }

        public UserDto User { get; set; }
    }
}
