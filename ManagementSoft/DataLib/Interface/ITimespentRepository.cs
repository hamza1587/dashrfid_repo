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
        Task<List<TimeSpent>> GetAllData();
        Task<List<TimeSpentOperations>> GetData(DateTime FromDate, DateTime ToDate);
        Task<List<TimeSpent>> GetDateData(DateTime FromDate, DateTime ToDate);
    }
}
