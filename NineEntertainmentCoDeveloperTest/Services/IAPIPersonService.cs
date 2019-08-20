using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NineEntertainmentCoDeveloperTest.Services
{
    interface IAPIPersonService
    {
        int GetNumberofPeople();
        int GetMiAge();
        int GetMaxAge();
        int GetAverageAge();
        int CountNumberofPeopleRace();
       
    }
}
