using CaseMediaMVC.Entities.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseMediaMVC.Busineess.Interfaces
{
    public interface INewsService
    {
        IEnumerable<NewsEntity> Get();
        NewsEntity Get(Guid guid);
        bool Add(NewsEntity news);

    }
}
