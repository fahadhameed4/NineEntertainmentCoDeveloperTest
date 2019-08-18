﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NineEntertainmentCoDeveloperTest.API.Models
{
    /// <summary>
    /// Angles implements Iperson interface as it 
    /// </summary>
    public class Hawaiian : Person<Hawaiian>
    {
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// return the details of Person
        /// </summary>
        /// <returns></returns>

        public override string ToString()
        {
            return "My name is '" + Name + "' and I am " + Age + " years old.";
        }
        /// <summary>
        /// this method returns height for people who lies in Angles race
        /// </summary>
        /// <returns></returns>
        public override double GetHeight()
        {
            return (1.7 + ((this.Age + 2) * 0.23));
        }
    }
}
