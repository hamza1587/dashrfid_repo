using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataLib.Interface;
using DataLib.Data;
using Microsoft.Extensions.Configuration;

namespace DataLib.Repository
{
    public class UnitofWork : IUnitofWork
    {
       // private readonly IMapper _mapper;
        private readonly DBContext _context;
        private IConfiguration Configuration;
        public UnitofWork(DBContext context, IConfiguration configuration)
        {
            _context = context;
            Configuration = configuration;
        }

        public IUsersRepository Users
        {
            get
            {
                return new UsersRepository(_context);
            }
        }
        public ITimespentRepository Timespent
        {
            get
            {
                return new TimespentRepository(_context);
            }
        }     
     
        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        public bool HasChanges()
        {
            return _context.ChangeTracker.HasChanges();
        }
    }
}
