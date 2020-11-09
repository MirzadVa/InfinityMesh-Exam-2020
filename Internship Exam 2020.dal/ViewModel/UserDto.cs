using Internship_Exam_2020.dal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_Exam_2020.dal.ViewModel
{
    public class UserDto
    {
        public UserDto()
        {

        }
        public UserDto(User user)
        {
            Id = user.Id;
            Name = user.Name;
            Age = user.Age;
            Email = user.Email;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }
    
}
