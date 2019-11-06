using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace POCO.Activities
{
    public class GetAvailabilty 
    {
        public string city { get; set; }
        public string start_date { get; set; }
        public string request_type { get; set; }
        public string attid { get; set; }
        public string description { get; set; }
        public string availability { get; set; }
        public string image { get; set; }
        public string rates { get; set; }
        public string product_name { get; set; }
        public string child_price { get; set; }
        public string adult_price { get; set; }
        public string currency { get; set; }
        public string adult_age_group { get; set; }
        public string child_age_group { get; set; }
    }

}

