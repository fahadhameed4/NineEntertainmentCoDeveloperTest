using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NineEntertainmentCoDeveloperTest.API.Models
{
    /// <summary>
    /// This is person interface 
    /// </summary>
   public interface IPerson
    {
         string Name { get; set; }
         int Age { get; set; }
         string ToString();
    }
}
