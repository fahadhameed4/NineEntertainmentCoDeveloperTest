using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NineEntertainmentCoDeveloperTest.API.Models
{
    /// <summary>
    /// This is person interface Repository 
    /// </summary>
   public interface IPersonRepository
    {
        Task<IEnumerable<IPerson>> InitPeople();
        bool AddPeople<T>();
        int NumberofPeople<T>(List<T> lisitofpeople);
        int AverageAge<T>(List<T> lisitofpeople);
        int MaxAge<T>(List<T> lisitofpeople);
        int MinAge<T>(List<T> lisitofpeople);
        int Count<T>(List<T> lisitofraces);
    }
}
