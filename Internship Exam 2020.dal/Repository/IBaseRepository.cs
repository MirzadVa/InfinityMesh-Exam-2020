using Internship_Exam_2020.dal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_Exam_2020.dal.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity 
    {
        TEntity Get(TEntity entity);
        TEntity Add(TEntity entity);

    }
}
