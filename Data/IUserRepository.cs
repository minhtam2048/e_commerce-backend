using System.Collections.Generic;
using System.Threading.Tasks;
using Shop_API.Models;

namespace Shop_API.Data
{
    public interface IMainRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool>SaveAll();
        Task<IEnumerable<User>> GetUsers();
        Task<IEnumerable<User>> GetUser();
    }
}