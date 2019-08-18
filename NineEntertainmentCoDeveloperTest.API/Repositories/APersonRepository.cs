using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NineEntertainmentCoDeveloperTest.API.Models
{
    /// <summary>
    /// This is person repository 
    /// </summary>
    abstract public class APersonRepository : IPersonRepository
    {
        public bool AddPeople<T>()
        {
            throw new NotImplementedException();
        }

        public int AverageAge<T>(List<T> lisitofpeople)
        {
            throw new NotImplementedException();
        }

        public int Count<T>(List<T> lisitofraces)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<IPerson>> InitPeople()
        {
            throw new NotImplementedException();
        }

        public int MaxAge<T>(List<T> lisitofpeople)
        {
            throw new NotImplementedException();
        }

        public int MinAge<T>(List<T> lisitofpeople)
        {
            throw new NotImplementedException();
        }

        public int NumberofPeople<T>(List<T> lisitofpeople)
        {
            throw new NotImplementedException();
        }
    }

}
