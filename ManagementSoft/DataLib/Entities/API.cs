using System;
using System.Collections.Generic;
using System.Text;

namespace DataLib.Entities
{
    public class API
    {
        public Example Example { get; set; }
        public List<TimeSpentOperations> TimeSpentOperations { get; set; }
        public List<TimeSpent> TimeSpent { get; set; }
    }
}
