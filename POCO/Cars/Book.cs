using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace POCO.Cars
{
    public class Book 
    {
        public string pickup_location  { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string EMAIL { get; set; }
        public string REF_ID { get; set; }
        public string COMPANY { get; set; }
        public string CAR_NAME { get; set; }
        public string CAR_CODE { get; set; }
        public string PASSENGER_QUANTITY { get; set; }
        public string BAGGAGE_QUANTITY { get; set; }
        public string ESTIMATED_TOTAL_AMOUNT { get; set; }
        public string PICKUP_LOCATION_CODE { get; set; }
        public string DROPOFF_LOCATION_CODE { get; set; }
        public string PICKUP_DATE_TIME { get; set; }
        public string RETURN_DATE_TIME { get; set; }
        public string RATE_CODE { get; set; }
        public string VOUCHER	 { get; set; }
        public string USER_REF_ID { get; set; }
        public string request_type { get; set; }
        public string Authorization { get; set; }
        public string RECORD_LOCATOR { get; set; }
        public string CONFIRMATION_ID	 { get; set; }
        public string VOUCHER { get; set; }
    }

}
