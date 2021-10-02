using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseMediaMVC.Helpers
{
    public class CaseMediaDBSettings : ICaseMediaDBSettings
    {
        public string DatabaseName { get; set; }
        public string ConnectionString { get; set; }
    }
}
