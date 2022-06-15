using Library.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(Guid id);
        Task<List<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task DeleteAsync(Guid id);
    }
}
