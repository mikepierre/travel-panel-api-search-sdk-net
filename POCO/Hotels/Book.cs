using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace POCO.Hotels
{
    public class Book
    {
      public string  HOTEL_ROOM_TYPE { get; set; }
      public string  PROVIDER_SOURCE { get; set; }
      public string  CURRENCY { get; set; }
      public string  PRODUCT_NAME { get; set; }
      public string  ADULT_QUANTITY { get; set; }
      public string  CHILD_QUANTITY { get; set; }
      public string  START_DATE { get; set; }
      public string  END_DATE { get; set; }
      public string  SESSID { get; set; }
      public string IMAGE { get; set; }
      public string TOTAL_PRICE	 { get; set; }
      public string FIRST_NAME { get; set; }
      public string LAST_NAME { get; set; }
      public string EMAIL { get; set; }
      public string SPECIAL_REQUEST { get; set; }
      public string QUANTITY { get; set; }
      public string BEDDING_CAPACITY { get; set; }
      public string PRODUCT_ID { get; set; }
      public string ADDRESS	 { get; set; }
      public string PHONE { get; set; }
      public string FAX { get; set; }
    }
}