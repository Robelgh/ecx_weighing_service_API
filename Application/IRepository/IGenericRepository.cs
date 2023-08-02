using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IRepository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetById(Guid Id);
        Task<IEnumerable<T>> GetAll();
        Task<T> Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task<bool> Exists(Guid id);

    }
}


  
