using Core.DataAccess.InMemory;
using Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryFuelDal : InMemoryEntityRepositoryBase<Fuel, int>,IFuelDal
    {
        protected override int generateId()
        {

            int nextId = _entities.Count == 0
              ? 1
              : _entities.Max(e => e.Id) + 1;
            return nextId;
        }
    }
}
