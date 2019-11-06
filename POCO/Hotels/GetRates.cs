using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace POCO.Hotels
{
    public class GetRates
    {    
      public string hotel_id { get; set; }
      public string  hotel_id { get; set; }
      public string  provider { get; set; }
      public string  check_in { get; set; }
      public string  check_out { get; set; }
      public string  passenger_total { get; set; }
      public string price { get; set; }
      public string roomType { get; set; }
      public string rate { get; set; }
      public string date { get; set; }
    }
}