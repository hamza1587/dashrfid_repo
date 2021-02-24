using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLib.Entities
{
    [Table("RFIDSysStatus")]
    public class RFIDSysStatus
    {
        [Key]
        public int id { get; set; }
        [MaxLength(50)]
        public string status_sys { get; set; }
        [MaxLength(100)]
        public string notes { get; set; }       
        public DateTime created_at { get; set; }
    }
}
