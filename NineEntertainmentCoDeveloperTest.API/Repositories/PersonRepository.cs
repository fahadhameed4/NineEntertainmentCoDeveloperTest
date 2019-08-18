using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NineEntertainmentCoDeveloperTest.API.Models
{
    /// <summary>
    /// This is person repository 
    /// </summary>
    public class PersonRepository
    {
        private readonly IPerson _person;
        
        public PersonRepository(IPerson person)
        {
            this._person = person;
        }

        public Person  AddRace()
        {
                return this._person;
        }

        public static List<Person> InitPeople()
        {
            List<Person> people = new List<Person>();
            Random rnd = new Random();
            for (int i = 0; i < 10000; i++)
            {
                people.Add(new Person()
                {
                    Name = "Person #" + i.ToString(),
                    Age = rnd.Next(1, 99)
                });
            }
            return people;
        }


    }
       
}
