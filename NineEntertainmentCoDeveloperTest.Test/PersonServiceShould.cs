using System;
using System.Collections.Generic;
using System.Text;
using NineEntertainmentCoDeveloperTest.APIModels;
using NineEntertainmentCoDeveloperTest.Models;
using NineEntertainmentCoDeveloperTest.Services;
using NUnit.Framework;

namespace NineEntertainmentCoDeveloperTest.Test
{
    class PersonServiceShould
    {
        PersonService _PersonService;
        public PersonServiceShould()
            {

            _PersonService = new PersonService();
           
            
          }
        [Test]
        public void GetAllRacesShould()
        {
            Assert.AreEqual(10000, _PersonService.GetAllRaces().Count);
        }

        [Test]
        public void GetHeightShould()
        {
            Person person = new Person();
            person.Age = 3;
            person.Height = 2.5;
            person.Name = "fahad";

            Assert.Greater(2, _PersonService.GetHeight(person));
        }

        [Test]
        public void GetMinAgehould()
        {
            Person person = new Person();
            person.Age = 3;
            person.Height = 2.5;
            person.Name = "fahad";

            Assert.Equals("Saxons", _PersonService.GetRace(1));
        }
       

        [Test]
        public void GetInitPeopleShould()
        {

        }
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();

        }

    }
}
