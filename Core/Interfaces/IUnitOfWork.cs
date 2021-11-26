using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IGeneticRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity;
        Task<int> Complete();
    }
}