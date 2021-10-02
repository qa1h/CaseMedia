using CaseMediaMVC.Data.Interfaces;
using CaseMediaMVC.Entities.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseMediaMVC.Data
{
    public class NewsRepository : BaseRepository<NewsEntity>, INewsRepository
    {
        public NewsRepository(ICaseMediaDBContext context) : base(context)
        {
            
        }
    }
}
