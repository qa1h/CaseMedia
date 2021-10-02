using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseMediaMVC.Entities.BusinessEntities
{
    public class CategoryEntity : BaseEntity
    {
        public string Title { get; set; }
        public string Slug { get; set; }
    }
}
