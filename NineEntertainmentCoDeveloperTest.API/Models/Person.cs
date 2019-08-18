using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NineEntertainmentCoDeveloperTest.API.Models
{
    /// <summary>
    /// This is generic abstract class as it allows to pass any class with different hieghts and races
    /// </summary>
    /// <typeparam name="T"></typeparam>
     abstract public class Person<T> : IPerson
    {
       virtual public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

       virtual public int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
       
        virtual public string   ToString()
        {
            return "My name is '" + Name + "' and I am " + Age + " years old.";
        }

        virtual public double GetHeight()
        {
            throw new NotImplementedException();
        }
    }
}
