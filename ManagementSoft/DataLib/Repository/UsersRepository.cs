using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataLib.Interface;
using DataLib.Data;
using DataLib.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace DataLib.Repository
{
    public class UsersRepository : IBaseRepository<Users>, IUsersRepository
    {
        private readonly DBContext _context;

        public UsersRepository(DBContext context)
        {
            _context = context;
        }

        public async Task Add(Users obj)
        {
           await _context.Users.AddAsync(obj);
        }

        public void Delete(Users obj)
        {
            _context.Entry(obj).State = EntityState.Deleted;
            _context.Users.Remove(obj);
        }

        public async Task<List<Users>> Get()
        {
            return await _context.Users.ToListAsync();

        }
        public async Task<List<Users>> GetByCondtion(Expression<Func<Users, bool>> expression)
        {
            return await _context.Users.Where(expression)
                .ToListAsync();
        }

        public async Task<Users> GetById(int id)
        {
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            return await _context.Users.FindAsync(id);
        }

        public void Update(Users obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            _context.Users.Update(obj);
        }
    
    }
}
