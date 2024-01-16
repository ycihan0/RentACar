using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    internal class EfModelDal : IModelDal
    {
        void IEntityRepository<Model, int>.Add(Model entity)
        {
            throw new NotImplementedException();
        }

        void IEntityRepository<Model, int>.Delete(Model entity)
        {
            throw new NotImplementedException();
        }

        Model? IEntityRepository<Model, int>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        IList<Model> IEntityRepository<Model, int>.GetList()
        {
            throw new NotImplementedException();
        }

        void IEntityRepository<Model, int>.Update(Model entity)
        {
            throw new NotImplementedException();
        }
    }
}
