using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseMediaMVC.Helpers
{
    public interface ICaseMediaDBSettings
    {
        string DatabaseName { get; set; }
        string ConnectionString { get; set; }
    }
}
