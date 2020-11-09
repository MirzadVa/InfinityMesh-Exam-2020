using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_Exam_2020.dal.Models
{
    public class Blog : BaseEntity
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }
        public DateTime PublishingDate { get; set; }
        public int UserId { get; set; }

        [JsonIgnore]
        public User User { get; set; }

        
        public Blog()
        {
            PublishingDate = DateTime.UtcNow;
        }


    }
}
