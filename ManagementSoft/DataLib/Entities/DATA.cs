using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLib.Entities
{
    public class DATA
    {
        public int VEHICLE_ID { get; set; }
        public string VIN { get; set; }
        public string BODY_NUM { get; set; }
        public string SEQ_NUM { get; set; }
        public string MODEL { get; set; }
        public string EXTERIOR_COLOR_CODE { get; set; }
        public string CONDITIONS { get; set; }
        public string RESP_SHOP { get; set; }
        public DateTime WAITING { get; set; }
        public DateTime REPAIRING { get; set; }
        public DateTime SPARE_PARTS { get; set; }
        public DateTime RETURNING { get; set; }
        public DateTime OUTSIDE { get; set; }
    }
}
