using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLib.Entities
{
    [Table("ReadingRPASFlux")]
    public class ReadingRPASFlux
    {
        [Key]
        public int id { get; set; }
        [MaxLength(100)]
        public DateTime readtime { get; set; }
        [MaxLength(50)]
        public string epc { get; set; }
        [ForeignKey("Associations")]
        public int? association_id { get; set; }
        public Associations Associations { get; set; }
        [MaxLength(50)]
        public string asset_status { get; set; }        
        public bool? is_active { get; set; }
        public DateTime created_at { get; set; }
    }
}
