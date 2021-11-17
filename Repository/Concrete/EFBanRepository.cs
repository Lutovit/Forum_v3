using Microsoft.EntityFrameworkCore;
using Repository.Absract;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Concrete
{
    class EFBanRepository : IBanRepository
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


        public IEnumerable<Message> GetWhere(Func<Message, bool> predicate)
        {
            return _context.BanEmails.Where(predicate).ToList();
        }


        public async Task<Message> FindByIdAsync(int id)
        {
            return await _context.BanEmails.FirstOrDefaultAsync(c => c.Id == id);
        }


        public async Task<Message> FindByIdWithIncludeUserAsync(int id)
        {
            return await _context.BanEmails.Include(m => m.User).FirstOrDefaultAsync(c => c.Id == id);
        }


        public async Task CreateAsync(Message item)
        {
            _context.BanEmails.Add(item);
            await _context.SaveChangesAsync();
        }


        public async Task UpdateAsync(Message item)
        {
            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }


        public async Task RemoveAsync(Message item)
        {
            _context.BanEmails.Remove(item);
            await _context.SaveChangesAsync();
        }
    }
}
