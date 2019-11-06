using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace POCO.Hotels
{
    public class ExternalMarkets
    {    
      public string  hotel_id { get; set; }
      public string  hotel_name { get; set; }
      public string  address { get; set; }
      public string  long_description { get; set; }
      public string  provider { get; set; }
      public string  image { get; set; }
      public string  name { get; set; }
    }
}