using Microsoft.EntityFrameworkCore;
using Repository.Absract;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.Concrete
{
    public class EFBanRepository : IBanRepository
    {
        ApplicationDbContext _context;


        public EFBanRepository(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<BanEmail>> GetAllAsync()
        {
            return await _context.BanEmails.ToListAsync();
        }


        IEnumerable<BanEmail> IBanRepository.GetWhere(Func<BanEmail, bool> predicate)
        {
            return _context.BanEmails.Where(predicate).ToList();
        }


        public async Task<BanEmail> FindByIdAsync(int id)
        {
            return await _context.BanEmails.FirstOrDefaultAsync(c => c.Id == id);
        }


        public async Task<BanEmail> FindByEmailAsync(string email)
        {
            return await _context.BanEmails.FirstOrDefaultAsync(c => c.Email == email);
        }


        public async Task CreateAsync(BanEmail item)
        {
            _context.BanEmails.Add(item);
            await _context.SaveChangesAsync();
        }


        public async Task UpdateAsync(BanEmail item)
        {
            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }


        public async Task RemoveAsync(BanEmail item)
        {
            _context.BanEmails.Remove(item);
            await _context.SaveChangesAsync();
        }

    }
}
