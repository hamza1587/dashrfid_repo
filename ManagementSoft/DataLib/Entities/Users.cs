using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLib.Entities
{
    [Table("Users")]
    public class Users
    {
        [Key]        
        public int id { get; set; }
        public string user_name { get; set; }       
        public string user_pass { get; set; }
        public string user_role { get; set; }     
        public bool is_active { get; set; }
        public DateTime created_at { get; set; }

    }
}
