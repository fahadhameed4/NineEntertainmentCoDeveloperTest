using NineEntertainmentCoDeveloperTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NineEntertainmentCoDeveloperTest.Services
{
    public class APIPersonService : IAPIPersonService
    {
        
        private readonly IPersonService _personService;
        private List<Person> people;

        public APIPersonService(IPersonService personService)
        {
            _personService = personService;
             people = new List<Person>();
             people= _personService.InitPeople();

        }

        public List<string> CountNumberofPeopleRace()
        {
            List<string> racescount = new List<string>();
            if(people.Count>0)
            {
                racescount.Add(people.Where(r => r.Race == Races.Angles).Count().ToString());
                racescount.Add(people.Where(r => r.Race == Races.Hawaiian).Count().ToString());
                racescount.Add(people.Where(r => r.Race == Races.Jutes).Count().ToString());
                racescount.Add(people.Where(r => r.Race == Races.Saxons).Count().ToString());
            }
            
            return racescount;
        }
        /// <summary>
        /// finds the average for all the ages 
        /// </summary>
        /// <returns></returns>

        public int GetAverageAge()
        {
            return _personService.GetAllRaces().Count > 0 ? Convert.ToInt32(_personService.GetAllRaces().Select(x => x.Age).ToList().Average()) : (Int32)0;
        }
        /// <summary>
        /// finds the Max of all the Ages
        /// </summary>
        /// <returns></returns>

        public int GetMaxAge()
        {
            return _personService.GetAllRaces().Count > 0 ? _personService.GetAllRaces().Select(x => x.Age).ToList().Max() : 0;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int GetMinAge()
        {
            return _personService.GetAllRaces().Count > 0 ? _personService.GetAllRaces().Select(x => x.Age).ToList().Min():0;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int GetNumberofPeople()
        {
            return _personService.GetAllRaces().Count > 0 ? _personService.GetAllRaces().Select(x => x.Age).ToList().Max() : 0;
        }

    }
}
