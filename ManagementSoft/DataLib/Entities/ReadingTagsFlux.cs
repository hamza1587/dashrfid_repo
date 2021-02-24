using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLib.Entities
{
    [Table("ReadingTagsFlux")]
    public class ReadingTagsFlux
    {
        [Key]
        public int id { get; set; }
        public DateTime readtime { get; set; }  
        [ForeignKey("ReadersInventory")]
        public int? reader_id { get; set; }
        public ReadersInventory ReadersInventory { get; set; }
        [ForeignKey("Associations")]
        public int? association_id { get; set; }
        public Associations Associations { get; set; }
        public bool? is_active { get; set; }
        public DateTime created_at { get; set; }
    }
}
