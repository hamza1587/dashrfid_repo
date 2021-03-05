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
    public class TimespentRepository : IBaseRepository<TimeSpent>, ITimespentRepository
    {
        private readonly DBContext _context;
        public TimespentRepository(DBContext context)
        {
            _context = context;
        } 
        

        public async Task<List<TimeSpent>> Get()
        {
            return await _context.TimeSpent.ToListAsync();
        }

        public async Task<List<TimeSpent>> GetDateData(DateTime FromDate, DateTime ToDate)
        {
            var results = await _context.TimeSpent.Where(x => x.created_at >= FromDate && x.created_at <= ToDate).ToListAsync();
            return results;
        }

        [Obsolete]
        public async Task<List<TimeSpentOperations>> GetViewData()
        {           
            var results = await _context.TimeSpentOperations.ToListAsync();
            return results;
        }

        public async Task<List<TimeSpent>> GetAllData()
        {
            var results = await _context.TimeSpent.ToListAsync();
            return results;
        }

        public async Task<List<TimeSpentOperations>> GetData(DateTime FromDate, DateTime ToDate)
        {
            var results = await _context.TimeSpentOperations.Where(x => x.created_at >= FromDate && x.created_at <= ToDate).ToListAsync();
            return results;
        }

        public async Task<TimeSpent> GetById(int id)
        {
            return await _context.TimeSpent.FindAsync(id);
        }

        public Task Add(TimeSpent obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(TimeSpent obj)
        {
            throw new NotImplementedException();
        }

        public Task<List<TimeSpent>> GetByCondtion(Expression<Func<TimeSpent, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Update(TimeSpent obj)
        {
            throw new NotImplementedException();
        }
    }
}
