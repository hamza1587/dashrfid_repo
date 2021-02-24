using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLib.Interface
{
    public interface IUnitofWork
    {
        IUsersRepository Users { get; }
        ITimespentRepository Timespent { get; }

        Task SaveAsync();
        void Save();
        bool HasChanges();
    }
}
