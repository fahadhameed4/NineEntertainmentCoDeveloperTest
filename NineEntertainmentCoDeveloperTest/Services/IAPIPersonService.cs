using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NineEntertainmentCoDeveloperTest.Services
{
    interface IAPIPersonService
    {
        int GetNumberofPeople();
        int GetMinAge();
        int GetMaxAge();
        decimal GetAverageAge();
        int CountNumberofPeopleRace();
       
    }
}
