using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace POCO.Activities
{
    public class GetAvailabilty 
    {
        public string request_type { get; set; }
        public string id { get; set; }
        public string city { get; set; }
    }

}
