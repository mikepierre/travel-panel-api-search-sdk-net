using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace POCO.Hotels
{
    public class GetHotelImages
    {    
      public string  hotel_id { get; set; }
        public string HOTEL_ID { get; set; }
        public string HOTEL_NAME { get; set; }
        public string ADDRESS { get; set; }
        public string CITY { get; set; }
        public string STATE { get; set; }
        public string ZIP { get; set; }
        public string COUNTRY { get; set; }
        public string PHONE { get; set; }
        public string RATING { get; set; }
        public string SHORT_DESCRIPTION { get; set; }
        public string LONG_DESCRIPTION { get; set; }
        public string AMENTITIES { get; set; }
        public string SMOKING { get; set; }
        public string LONGITUDE { get; set; }
        public string LATITUDE { get; set; }
        public string CHECK_IN_TIME { get; set; }
        public string CHECK_OUT_TIME { get; set; }
        public string AIRPORT_CODE { get; set; }
        public string NUMBER_OF_HOTEL_ROOMS { get; set; }
        public string VICINITY { get; set; }
        public string TAX_RATE { get; set; }
    }
}