using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseMediaMVC.Entities.BusinessEntities
{
    public class StoryEntity : BaseEntity
    {

        public ContentEntity[] Contents { get; set; }
    }
}
