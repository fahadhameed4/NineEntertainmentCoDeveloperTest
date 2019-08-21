using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NineEntertainmentCoDeveloperTest.Services
{
    public class LoggerService:ILoggerService
    {
        public void Handle(string path,string error)
        {
            System.IO.File.WriteAllText(path, error);
        }
    }
}
