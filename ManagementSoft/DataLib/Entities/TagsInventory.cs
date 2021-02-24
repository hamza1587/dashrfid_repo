using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLib.Entities
{
    [Table("TagsInventory")]
    public class TagsInventory
    {
        [Key]
        public int id { get; set; }
        [MaxLength(50)]
        public string epc { get; set; }
        [MaxLength(100)]
        public string userdata { get; set; }
        [MaxLength(50)]
        public string tagfunction { get; set; }
        [MaxLength(50)]
        public string tagstatus { get; set; }        
        public bool? is_active { get; set; }
        public DateTime created_at { get; set; }
    }
}
