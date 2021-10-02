using CaseMediaMVC.Entities.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseMediaMVC.Data.Interfaces
{
    public interface INewsRepository : IBaseRepository<NewsEntity>
    {
    }
}
