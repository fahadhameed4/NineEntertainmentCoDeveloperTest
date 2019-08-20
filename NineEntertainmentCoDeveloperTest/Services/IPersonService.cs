using NineEntertainmentCoDeveloperTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NineEntertainmentCoDeveloperTest.Models
{
    /// <summary>
    /// This is person interface 
    /// </summary>
   public interface IPersonService
    {
        List<APIPerson> InitPeople();
        List<APIPerson> AddYearToAge(List<APIPerson> persons);
        Races GetRace(int raceId);
        double GetHeight(APIPerson person);
        List<APIPerson> GetAllRaces();
        List<APIPerson> GetPersonsByRace(Races race);
    }
}
