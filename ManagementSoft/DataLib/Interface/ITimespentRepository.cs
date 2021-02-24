using DataLib.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLib.Interface
{
    public interface ITimespentRepository : IBaseRepository<TimeSpent>
    {
        Task<List<TimeSpentOperations>> GetViewData();
    }
}
