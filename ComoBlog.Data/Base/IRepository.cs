using System.Collections.Generic;
using System.Threading.Tasks;

namespace ComoBlog.Data.Base
{
    public interface IRepository<T> where T : IEntity
    {
        Task<IEnumerable<T>> GetItemsAsync(string query);
        Task<T> GetItemAsync(string id);
        Task AddItemAsync(T item);
        Task UpdateItemAsync(string id, T item);
        Task DeleteItemAsync(string id);
    }
}
