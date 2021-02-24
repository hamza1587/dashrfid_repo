using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLib.Entities
{
    [Table("RFIDNotifications")]
    public class RFIDNotifications
    {
        [Key]
        public int id { get; set; }
        [MaxLength(50)]
        public string title_n { get; set; }
        [MaxLength(150)]
        public string description_n { get; set; }
        [MaxLength(50)]
        public string status_n { get; set; }
        [MaxLength(50)]
        public string reference_n { get; set; }        
        public bool? is_active { get; set; }
        public DateTime created_at { get; set; }
    }
}
