using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSqLite.Services
{
    //<T> O objeto generico que vamos vincular
    public interface IDataStore<T> 
    {
        Task<bool> AddAsync(T value);
        Task<bool> UpdateAsync(T value);
        Task<bool> DeleteAsync(T value);
        Task<List<T>> GetAllAsync();
    }
}
