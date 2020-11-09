using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_Exam_2020.dal.Models
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        
        public List<Blog> Blogs { get; set; }

       
       

        public override string ToString()
        {
            return Name.ToLower();
        }
    }
}
