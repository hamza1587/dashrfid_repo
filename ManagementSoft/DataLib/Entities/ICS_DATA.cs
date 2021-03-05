using System;
using System.Collections.Generic;
using System.Text;

namespace DataLib.Entities
{
    //public class ICS_DATA
    //{
    //    public List<RESULT> DATA { get; set; }
    //}

    public class ICS_DATA
    {
        //public string VEHICLE_ID { get; set; }
        //public string VIN { get; set; }
        //public string BODY_NUM { get; set; }
        //public string SEQ_NUM { get; set; }
        //public string MODEL { get; set; }
        //public string EXTERIOR_COLOR_CODE { get; set; }
        //public string CONDITIONS { get; set; }
        //public string RESP_SHOP { get; set; }
        //public string WAITING { get; set; }
        //public string REPAIRING { get; set; }
        //public string SPARE_PARTS { get; set; }
        //public string RETURNING { get; set; }
        //public string OUTSIDE { get; set; }

        public int order_id { get; set; }
        public decimal amount { get; set; }
        public int response_code { get; set; }
        public string response_desc { get; set; }
    }
}
