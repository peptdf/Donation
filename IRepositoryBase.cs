using System;
using System.Collections.Generic;
using System.Text;
using Donation.Domain.Interfaces.Repositories;

namespace Donation.Domain.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {

        void add(TEntity obj);

        TEntity GetById(string id);

        IEnumerable<TEntity> Getall();

        void Update(TEntity obj);

        void Remove(TEntity obj);

        void Dispose();
    }
}
