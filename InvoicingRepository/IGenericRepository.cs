using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoicingRepository
{
    public interface IGenericRepository<T> where T : class 
    {
        IQueryable<T> GetAll();

        Task Create(T entity);

        Task Update(int id, T entity);

        Task Delete(int id);
    }
}
