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

        public APIPersonService(IPersonService personService)
        {
            _personService = personService;
        }
        public int CountNumberofPeopleRace()
        {
            return 0;
        }
        /// <summary>
        /// finds the average for all the ages 
        /// </summary>
        /// <returns></returns>

        public decimal GetAverageAge()
        {
            return _personService.GetAllRaces().Count > 0 ? Convert.ToDecimal(_personService.GetAllRaces().Select(x => x.Age).ToList().Average()) : (decimal)0;
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
