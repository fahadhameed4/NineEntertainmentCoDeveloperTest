﻿using NineEntertainmentCoDeveloperTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NineEntertainmentCoDeveloperTest.API.Models
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Person 
    {
       public string Name { get; set ; }
       public int Age { get; set; }
        /// <summary>
        /// Task 1 class structure, to implement the following races: Angles,Saxons, Jutes and Hawaiian
        /// </summary>
       public Races Race { get; set; }
       public string GetToString()
        {
            return "My name is '" + Name + "' and I am " + Age + " years old.";
        }
    }

}
