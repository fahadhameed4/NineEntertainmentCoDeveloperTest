using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NineEntertainmentCoDeveloperTest.Services
{
   public interface IAPIPersonService
    {
        int GetNumberofPeople();
        int GetMinAge();
        int GetMaxAge();
        int GetAverageAge();
        List<string> CountNumberofPeopleRace();
       
    }
}
