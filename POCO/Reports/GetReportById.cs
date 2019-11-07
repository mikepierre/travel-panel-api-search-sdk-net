using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace POCO.Reports
{
    public class GetReportById 
    {

        public string Authorization { get; set; }
        public string reference_id { get; set; }
        public string Authorization { get; set; }
        public string PRODUCT_ID { get; set; }
        public string PRODUCT_NAME { get; set; }
        public string SERVICE { get; set; }
        public string SESS_ID { get; set; }
        public string GRAND_TOTAL { get; set; }
        public string START_LOCATION { get; set; }
        public string END_LOCATION { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string RESERVATION_DATE { get; set; }
        public string IS_CANCELLED { get; set; }
        public string PROVIDER { get; set; }
        public string PRODUCT_TYPE { get; set; }
        public string ADULT_QUANTITY { get; set; }
        public string CHILD_QUANTITY { get; set; }
        public string START_DATE { get; set; }
        public string END_DATE { get; set; }
        public string CAR_RENTAL_RATE_CODE { get; set; }
    }

}