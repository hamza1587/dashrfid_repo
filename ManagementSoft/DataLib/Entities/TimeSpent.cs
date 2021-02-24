using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLib.Entities
{
    public class TimeSpent
    {     
        public int association_id { get; set; }
        public int location_id { get; set; }
        public string location_name { get; set; }
        public int asset_id { get; set; }
        public string minutes_log { get; set; }
        public string minutes_from_now { get; set; } 
    }
}
