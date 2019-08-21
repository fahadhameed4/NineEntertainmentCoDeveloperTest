using System;
using System.Collections.Generic;
using System.Text;
using NineEntertainmentCoDeveloperTest.APIModels;
using NineEntertainmentCoDeveloperTest.Services;
using NUnit.Framework;

namespace NineEntertainmentCoDeveloperTest.Test
{
    class PersonControllerShould
    {
        PersonService _PersonService;
        public PersonControllerShould()
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

        }

        [Test]
        public void GetMinAgehould()
        {

        }
        [Test]
        public void GetMaxAgehould()
        {

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
