using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NineEntertainmentCoDeveloperTest.Services
{
   public interface ILoggerService
    {

        void Handle(string path,string error);
    }
}
