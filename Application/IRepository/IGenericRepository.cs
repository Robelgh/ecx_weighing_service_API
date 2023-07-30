using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IRepository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetById(Guid id);
        Task<IReadOnlyList<T>> GetAll();
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> DeleteById(Guid id);

    }
}
