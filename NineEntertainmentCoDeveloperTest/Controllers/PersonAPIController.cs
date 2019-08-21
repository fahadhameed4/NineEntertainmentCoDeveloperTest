using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NineEntertainmentCoDeveloperTest.APIModels;
using NineEntertainmentCoDeveloperTest.Services;

namespace NineEntertainmentCoDeveloperTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonAPIController : ControllerBase
    {
        
        private readonly IAPIPersonService _aPIPersonService;
        private readonly ILoggerService _loggerService;
        public PersonAPIController(IAPIPersonService aPIPersonService,ILoggerService loggerService)
        {
            _aPIPersonService = aPIPersonService;
            _loggerService = loggerService;
        }
        // GET: api/Person
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }


        // GET: api/Person
        [HttpGet("Races")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(APIPerson), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public APIPerson GetRaces()
        {
                try
                {
                    return new APIPerson
                    {
                        AverageAge =  _aPIPersonService.GetAverageAge(),
                        MinAge = _aPIPersonService.GetMinAge(),
                        MaxAge = _aPIPersonService.GetMaxAge(),
                        NumberofPeople = _aPIPersonService.GetNumberofPeople(),
                        NumberofPeopleRaces = _aPIPersonService.CountNumberofPeopleRace()

                    };

                }

                catch (Exception ex)
                {
                    // save the message
                    //First  argument of Handle will come from configuration
                   _loggerService.Handle("", ex.ToString());
                }
            return new APIPerson
            {
                AverageAge = 0,
                MinAge = 0,
                MaxAge = 0,
                NumberofPeople = 0
            };

        }

        // GET: api/Person/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Person
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Person/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
