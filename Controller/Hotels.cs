using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using POCO.Hotels;

namespace Controller.Hotels
{
    public class Hotels
    {
        static HttpClient client = new HttpClient();

        static aysnc Task<Book> book()
        {

        }

        static aysnc Task<ExternalMarkets> getExternalMarkets(){}

        static aysnc Task<GetAllHotelIds> getlIds(){}

        static aysnc Task<GetHotelImages> getImages(){}

        static aysnc Task<GetHotelProfileByID> getProfileById(){}

        static aysnc Task<GetHotelProfileByLocation> getLocations(){}

        static aysnc Task<GetRates> getRates(){}

        static aysnc Task<SearchHotels> searchHotels(){}
    }
}