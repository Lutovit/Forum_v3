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
    public class EFMessageRepository : IMessageRepository
    {
        ApplicationDbContext _context;


        public EFMessageRepository(ApplicationDbContext context)
        {
            _context = context;
        }



        public async Task<IEnumerable<Message>> GetAllAsync()
        {
            return await _context.Messages.ToListAsync();
        }

        public async Task<IEnumerable<Message>> GetAllWithIncludeUserAsync()
        {
            return await _context.Messages.Include(m=>m.User).ToListAsync();
        }



        public IEnumerable<Message> Get(Func<Message, bool> predicate)
        {
            return _context.Messages.Where(predicate).ToList();
        }



        public async Task<Message> FindByIdAsync(int id)
        {
            return await _context.Messages.FirstOrDefaultAsync(c => c.Id == id);        
        }

        public async Task<Message> FindByIdWithIncludeUserAsync(int id)
        {
            return await _context.Messages.Include(m => m.User).FirstOrDefaultAsync(c=>c.Id==id);
        }



        public async Task CreateAsync(Message item)
        {
            _context.Messages.Add(item);
            await _context.SaveChangesAsync();
        }


        public async Task UpdateAsync(Message item)
        {
            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }


        public async Task RemoveAsync(Message item)
        {
            _context.Messages.Remove(item);
            await _context.SaveChangesAsync();
        }
    }
}
