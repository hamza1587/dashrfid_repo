using System;
using System.Collections.Generic;
using System.Text;

namespace DataLib.Entities
{
    public class API
    {
        public Example Example { get; set; }
        public IList<TimeSpentOperations> TimeSpentOperations { get; set; }
        public IList<TimeSpent> TimeSpent { get; set; }
    }
}
