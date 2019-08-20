using NineEntertainmentCoDeveloperTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NineEntertainmentCoDeveloperTest.Models
{
    /// <summary>
    /// This is generic abstract class as it allows to pass any class with different hieghts and races
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Person 
    {
       public string Name { get; set ; }
       public int Age { get; set; }
       public Races Race { get; set; }
       public double Height { get;set; }
       public new string ToString => "My name is '" + Name + "' and I am " + Age + " years old.";

    }

   
}
