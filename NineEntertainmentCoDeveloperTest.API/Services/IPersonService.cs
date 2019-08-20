using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NineEntertainmentCoDeveloperTest.API.Models
{
    /// <summary>
    /// This is person interface 
    /// </summary>
   public interface IPersonService
    {
        List<Person> InitPeople();
        double GetHeight(Person person);
        List<Person> AddYearToAge(List<Person> persons);
        List<Person> GetPersonsByRace(Races race);
    }
}
