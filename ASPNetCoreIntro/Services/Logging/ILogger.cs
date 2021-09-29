using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreIntro.Services.Logging
{
     public interface ILogger
    {
       void Log(string logMessage);

    }
}
