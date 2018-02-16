using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCoreTutorialGit;
using Microsoft.EntityFrameworkCore;

namespace InvoicingRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public readonly InvoicingToolContext _invoicingContext;
        public GenericRepository(InvoicingToolContext invoicingContext)
        {
            _invoicingContext = invoicingContext;
        }
        public async Task Create(T entity)
        {
            await _invoicingContext.Set<T>().AddAsync(entity);
            await _invoicingContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = GetById(id);
            _invoicingContext.Set<T>().Remove(entity);
            await _invoicingContext.SaveChangesAsync();
        }

        public IQueryable<T> GetAll()
        {
            return _invoicingContext.Set<T>().AsNoTracking();
        }

        public T GetById(int id)
        {
            return _invoicingContext.Set<T>().Find(id);
        }

        public async Task Update(int id, T entity)
        {
            _invoicingContext.Set<T>().Update(entity);
            await _invoicingContext.SaveChangesAsync();
        }
    }
}
