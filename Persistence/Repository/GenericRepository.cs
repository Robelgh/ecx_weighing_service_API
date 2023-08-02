using Application.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
{

        public class GenericRepository<T> : IGenericRepository<T> where T : class
        {
            private readonly ECXDBContext _context;

            public GenericRepository(ECXDBContext context)
            {
                _context = context;
            }

            public async Task<T> Add(T entity)
            {
                await _context.AddAsync(entity);
                await _context.SaveChangesAsync();
                return entity;
            }

            public async Task Delete(T entity)
            {
                _context.Set<T>().Remove(entity);
                await _context.SaveChangesAsync();
            }

            public async Task<bool> Exists(Guid id)
            {
                var entiry = await GetById(id);
                return entiry != null;
            }

            public async Task<IEnumerable<T>> GetAll()
            {
                return await _context.Set<T>().ToListAsync();
            }

            public async Task<T> GetById(Guid Id)
            {
                return await _context.Set<T>().FindAsync(Id);
            }
            public async Task Update(T entity)
            {
                _context.Entry(entity).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
    }
  }

