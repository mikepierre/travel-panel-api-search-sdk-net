using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace POCO.Hotels
{
    public class SearcHotels
    {    
        public string location  { get; set; }
        public string check_in  { get; set; }
        public string check_out  { get; set; }
        public string rooms { get; set; }
        public string adults { get; set; }
        public string children { get; set; }
        public string childrenAges { get; set; }
        public string request_type { get; set; }
        public string HOTEL_NAME { get; set; }
        public string HOTEL_ID { get; set; }
        public string IMAGE { get; set; }
        public string RATING { get; set; }
        public string IP_ADDRESS { get; set; }
        public string CONTRACT_TYPE { get; set; }
        public string CURRENCY { get; set; }
        public string ADDRESS { get; set; }
        public string SEARCH_ID { get; set; }
        public string NEIGHBORHOOD { get; set; }
        public string NET_RATE { get; set; }
        public string MIN_AVER_PUBLISH_PRICE { get; set; }
        public string HOTEL_ROOM_TYPE_ID { get; set; }
        public string DESCRIPTION	{ get; set; }
        public string BB_ID { get; set; }
        public string BB_NAME { get; set; }	
        public string OCCUP_PRICE { get; set; }
    }
}
