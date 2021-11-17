using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.Absract
{
    public interface IBanRepository
    {
        Task<IEnumerable<BanEmail>> GetAllAsync();

        IEnumerable<BanEmail> GetWhere(Func<BanEmail, bool> predicate);


        Task<BanEmail> FindByIdAsync(int id);

        Task<BanEmail> FindByEmailAsync(string email);


        Task CreateAsync(BanEmail item);

        Task UpdateAsync(BanEmail item);

        Task RemoveAsync(BanEmail item);
    }
}
