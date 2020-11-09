using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_Exam_2020.dal.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }

        public BaseEntity()
        {
            CreatedAt = DateTime.UtcNow;
        }
    }
   
}
