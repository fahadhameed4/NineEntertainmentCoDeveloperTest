
using NineEntertainmentCoDeveloperTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NineEntertainmentCoDeveloperTest.Services
{
    public class PersonService : IPersonService 
    {
        /// <summary>
        /// List of People
        /// </summary>
        List<Person> people = new List<Person>();
        public PersonService()
        {
            this.people =  this.InitPeople();
        }
        /// <summary>
        /// this method adds people to list randomly
        /// </summary>
        /// <returns></returns>
        public List<Person> InitPeople()
        {
            List<Person> people = new List<Person>();
            Random rnd = new Random();
            for (int i = 0; i < 10000; i++)
            {
                Person person = new Person();

                person.Name = "Person #" + i.ToString();
                person.Age = rnd.Next(1, 99);
                person.Race = GetRace(rnd.Next(1, 4));
                person.Height = GetHeight(person);
                people.Add(person);
            }
            return  people;
        }
        /// <summary>
        /// Add one one year to existing age
        /// </summary>
        /// <param name="persons"></param>
        /// <returns></returns>

        public List<Person> AddYearToAge(List<Person> persons)
        {
            foreach(Person person in persons)
            {
                person.Age = +1;
            }
            return persons;
        }
        /// <summary>
        /// This will get the Race 
        /// </summary>
        /// <param name="raceId"></param>
        /// <returns></returns>

        public Races GetRace(int raceId)
        {
         
            if (raceId == (int)Races.Angles)
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
        /// <summary>
        /// Return list of all people 
        /// </summary>
        /// <returns></returns>
 
        public List<Person>  GetAllRaces()
        {
            return this.people;

        }
        /// <summary>
        /// Get list of persons for specific race
        /// </summary>
        /// <param name="race"></param>
        /// <returns></returns>

        public  List<Person> GetPersonsByRace(Races race) 
        {
            return   this.people.Where(x => x.Race == race && x.Age%2==0).OrderBy(x=>x.Age).ToList();
        }
        
        /// <summary>
        /// return height on basis of races 
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public double GetHeight(Person person)
        { 
            switch(person.Race)
            {
                case Races.Angles:
                    return (1.5 + (person.Age * 0.45));

                case Races.Saxons:
                    return (1.5 + (person.Age * 0.45));

                case Races.Jutes:
                    return ((person.Age * 1.6) / 2); 

                case Races.Hawaiian:
                    return (1.7 + ((person.Age + 2) *0.23));

                default:
                    return 0;

            }
         
        }

       
    }
}
