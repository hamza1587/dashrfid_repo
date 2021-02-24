using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLib.Entities
{
    [Table("Associations")]
    public class Associations
    {
        [Key]
        public int id { get; set; }
        public DateTime readtime { get; set; }     
        public string association_name { get; set; }
        public int? user_id { get; set; }
        [ForeignKey("ReadersInventory")]
        public int? reader_id { get; set; }
        public ReadersInventory ReadersInventory { get; set; }
        [ForeignKey("TagsInventory")]
        public int? tag_id { get; set; }
        public TagsInventory TagsInventory { get; set; }
        [MaxLength(50)]
        public string asset_id { get; set; }
        public bool? is_active { get; set; }
        public DateTime created_at { get; set; }
    }
}
