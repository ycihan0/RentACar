using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    internal class EfFuelDal : IFuelDal
    {
        public void Add(Fuel entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Fuel entity)
        {
            throw new NotImplementedException();
        }

        public Fuel? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Fuel> GetList()
        {
            throw new NotImplementedException();
        }

        public void Update(Fuel entity)
        {
            throw new NotImplementedException();
        }
    }
}
