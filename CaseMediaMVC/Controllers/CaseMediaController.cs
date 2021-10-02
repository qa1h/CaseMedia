using CaseMediaMVC.Busineess.Interfaces;
using CaseMediaMVC.Entities.BusinessEntities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseMediaMVC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CaseMediaController : ControllerBase
    {
        private readonly IServiceProvider _collection;

        public CaseMediaController(IServiceProvider collection)
        {
            _collection = collection;
        }


        [HttpGet]
        [Route("Get")]
        public IEnumerable<NewsEntity> Get()
        {
            using (var scope = _collection.CreateScope())
            {
                return _collection.GetService<INewsService>().Get();
            }
        }

        [HttpGet]
        [Route("GetDetail")]
        public NewsEntity Get(Guid guid)
        {
            using (var scope = _collection.CreateScope())
            {
                return _collection.GetService<INewsService>().Get(guid);
            }
        }

        [HttpPost]
        [Route("Add")]
        public bool Add(NewsEntity request)
        {
            using (var scope = _collection.CreateScope())
            {
                return _collection.GetService<INewsService>().Add(request);
            }
        }

    }
}
