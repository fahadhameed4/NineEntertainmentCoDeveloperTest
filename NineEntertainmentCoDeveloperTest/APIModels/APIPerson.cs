using NineEntertainmentCoDeveloperTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NineEntertainmentCoDeveloperTest.APIModels
{
    /// <summary>
    /// this model is for API endpoints
    /// </summary>
    public class APIPerson 
    {
       public int  NumberofPeople { get; set ; }
       public int AverageAge { get; set; }
       public int MinAge { get; set; }
       public int MaxAge { get; set; }
       public int CountNumberofPeopleRace { get; set; }

    }

   
}
