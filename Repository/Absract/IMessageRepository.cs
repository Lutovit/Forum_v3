using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.Absract
{
    public interface IMessageRepository
    {
        Task<IEnumerable<Message>> GetAllAsync();
        Task<IEnumerable<Message>> GetAllWithIncludeUserAsync();


        IEnumerable<Message> Get(Func<Message, bool> predicate);


        Task<Message> FindByIdAsync(int id);
        Task<Message> FindByIdWithIncludeUserAsync(int id);


        Task CreateAsync(Message item);
        Task UpdateAsync(Message item);
        Task RemoveAsync(Message item);
    }
}
