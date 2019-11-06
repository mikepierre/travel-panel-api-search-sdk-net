using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace POCO.Hotels
{
    public class GetAllHotelIds
    {    
      public string  hotel_id { get; set; }
      public string  hotel_name { get; set; }
      public string  zip { get; set; }
    }
}