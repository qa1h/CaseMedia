using CaseMediaMVC.Busineess.Interfaces;
using CaseMediaMVC.Data.Interfaces;
using CaseMediaMVC.Entities.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace CaseMediaMVC.Busineess
{
    public class NewsService : INewsService
    {
        private readonly IServiceProvider _collection;
        public NewsService(IServiceProvider collection)
        {
            _collection = collection;
        }

        public IEnumerable<NewsEntity> Get()
        {

            return _collection.GetService<INewsRepository>().GetAll();

        }

        public NewsEntity Get(Guid guid)
        {
            return _collection.GetService<INewsRepository>().GetById(guid);
        }

        public bool Add(NewsEntity news)
        {

            var retNew = _collection.GetService<INewsRepository>().Add(news);

            return retNew != null ? true : false;
        }
    }
}
