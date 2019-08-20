using NineEntertainmentCoDeveloperTest.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NineEntertainmentCoDeveloperTest.API.Services
{
    public class PersonService : IPersonService 
    {
        public PersonService()
        {
            this.people =  this.InitPeople();
        }
        List<Person> people = new List<Person>();

        public List<Person> InitPeople()
        {
            List<Person> people = new List<Person>();
            Random rnd = new Random();
            for (int i = 0; i < 10000; i++)
            {
                people.Add(new Person()
                {
                    Name = "Person #" + i.ToString(),
                    Age = rnd.Next(1, 99),
                    Race =  GetRace( rnd.Next(1, 4))
                });
            }
            return people;
        }

        public List<Person> AddYearToAge(List<Person> persons)
        {
            foreach(Person person in persons)
            {
                person.Age = +1;
            }
            return persons;
        }

        private Races GetRace(int raceId)
        {
            if (raceId == 1)
            {
                return Races.Angles;
            }
            else if (raceId == 2)
            {
                return Races.Saxons;
            }
            else if (raceId == 3)
            {
                return Races.Jutes;
            }
            else
            {
                return Races.Hawaiian;

            }
        } 

        // GetAllRaces(); // to show in drop down

        public List<Person> GetPersonsByRace(Races race) // to get list of persons of specifc race
        {
            return this.people.Where(x => x.Race == race).ToList();
        }

        public double GetHeight(Person person)
        {
            if(person.Race == Races.Angles)
            {
                return 1;
            }
            else if (person.Race == Races.Saxons)
            {
                return 2;
            }
            else if (person.Race == Races.Jutes)
            {
                return 3;
            }else
            {
                return 4;

            }

        }
    }
}
