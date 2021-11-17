using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.Absract
{
    public interface ITopicRepository
    {
        Task<IEnumerable<Topic>> GetAllAsync();
        Task<IEnumerable<Topic>> GetAllWithIncludeMessagesAsync();
        Task<IEnumerable<Topic>> GetAllFromDateWithIncludeMessagesAsync(DateTime dateOflastMessageFrom);


        IEnumerable<Topic> Get(Func<Topic, bool> predicate);


        Task<Topic> FindByIdAsync(int id);
        Task<Topic> FindByIdWithIncludeMessagesAsync(int id);


        Task CreateAsync(Topic item);
        Task UpdateAsync(Topic item);
        Task RemoveAsync(Topic item);
    }
}
