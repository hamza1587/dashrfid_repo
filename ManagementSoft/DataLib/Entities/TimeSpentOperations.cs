using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLib.Entities
{
    public class TimeSpentOperations
    {
        public int association_id { get; set; }
        public int location_id { get; set; }
        public string location_name { get; set; }      
        public string asset_id { get; set; }
        public int minutes_from_now { get; set; }
        public int location_count { get; set; }
        public int total_minutes { get; set; }
    }
}
