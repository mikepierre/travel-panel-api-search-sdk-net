using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace POCO.Transfers
{
    public class GetTransferAvailablity
 
    {
        public string pickup_location  { get; set; }
        public string check_in  { get; set; }
        public string pickup_time  { get; set; }
        public string dropp_off_location  { get; set; }
        public string car_type  { get; set; }
        public string rate_code  { get; set; }
        public string request_type  { get; set; }
        public string REFERENCE_ID  { get; set; }
        public string REFERENCE_TYPE  { get; set; }
        public string COMPANY  { get; set; }
        public string COMPANY_LOGO  { get; set; }
        public string IP_ADDRESS  { get; set; }
        public string CAR_NAME  { get; set; }
        public string CAR_CODE  { get; set; }
        public string PICTURE_URL  { get; set; }
        public string DOOR_COUNT { get; set; }
        public string PASSENGER_QUANTITY  { get; set; }
        public string BAGGAGE_QUANTITY  { get; set; }
        public string VENDOR_CAR_TYPE  { get; set; }
        public string ESTIMATED_TOTAL_AMOUNT  { get; set; }
        public string CURRENCY_CODE  { get; set; }
        public string PICKUP_LOCATION_CODE  { get; set; }
        public string PICKUP_LOCATION  { get; set; }
        public string DROPOFF_LOCATION_CODE  { get; set; }
        public string DROPOFF_LOCATION  { get; set; }
        public string PICKUP_DATE_TIME  { get; set; }
        public string RETURN_DATE_TIME  { get; set; }
        public string RATE_CODE  { get; set; }
        public string RATE_TOTAL_AMOUNT  { get; set; }
        public string FEES_JSON { get; set; }
    }

}
