using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.A.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.A.Data
{
    public class DatingRepository : IDatingRepository
    {
        private readonly DataContext _context;
        public DatingRepository(DataContext context)
        {
            _context = context;

        }
        public void Add<T>(T entity) where T : class
        {
           _context.Add(entity);
        }

        public void delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<User> GetUser(int Id)
        {
           var user = await _context.Users.Include(p => p.Photos).FirstOrDefaultAsync(u => u.Id==Id);
            return user;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var users= await _context.Users.Include(p => p.Photos).ToListAsync();
            return users;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}