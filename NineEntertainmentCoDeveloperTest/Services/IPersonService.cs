using NineEntertainmentCoDeveloperTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NineEntertainmentCoDeveloperTest.Services
{
    /// <summary>
    /// This is person interface 
    /// </summary>
   public interface IPersonService
    {
        List<Person> InitPeople();
        List<Person> AddYearToAge(List<Person> persons);
        Races GetRace(int raceId);
        double GetHeight(Person person);
        List<Person> GetAllRaces();
        List<Person> GetPersonsByRace(Races race);
    }
}
