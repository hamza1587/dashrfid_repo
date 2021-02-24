using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLib.Entities
{
    [Table("RFIDLocations")]
    public class RFIDLocations
    {
        [Key]
        public int id { get; set; }
        [MaxLength(50)]
        public string location_name { get; set; }
        [MaxLength(50)]
        public string location_type { get; set; }       
        public bool? is_active { get; set; }
        public DateTime created_at { get; set; }
    }
}
