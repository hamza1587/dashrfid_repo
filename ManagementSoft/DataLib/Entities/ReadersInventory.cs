using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLib.Entities
{
    [Table("ReadersInventory")]
    public class ReadersInventory
    {
        [Key]
        public int id { get; set; }
        [MaxLength(100)]
        public string reader_name { get; set; }
        [MaxLength(20)]
        public string reader_type { get; set; }
        [MaxLength(25)]
        public string reader_ip { get; set; }
        [MaxLength(50)]
        public string reader_macaddress { get; set; }
        [MaxLength(100)]
        public string reader_status { get; set; }
        [ForeignKey("RFIDLocations")]
        public int? location_id { get; set; }
        public RFIDLocations RFIDLocations { get; set; }
        [MaxLength(100)]
        public string sets_status { get; set; }
        public bool? connection_check { get; set; }
        public bool? is_active { get; set; }
        public DateTime created_at { get; set; }
    }
}
