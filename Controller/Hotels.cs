using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Collections.Generic; 

using POCO.Hotels;

namespace Controller.Hotels
{
    public class Hotels
    {
        // HttpClient is intended to be instantiated once per application, rather than per-use.
        static HttpClient client = new HttpClient();

        // Books the hotel.
        /// <summary>
        /// Books the hotel.
        /// </summary>
        /// <returns>
        /// The Response URI of the resource created. 
        /// </returns>
        /// /// <param name="params">A Dictonary Collection</param>
        /// /// <param name="a">A double precision number.</param>
        static aysnc Task<Book> bookAysnc(Dictionary<string, string> params)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "END_POINT", params);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }

        // Get External Markets.
        /// <summary>
        /// Get External Markets.
        /// </summary>
        /// <returns>
        /// A Response Object. 
        /// </returns>
        /// /// <param name="params">A Dictonary Collection</param>
        /// /// <param name="path">A String</param>
        static aysnc Task<ExternalMarkets> getExternalMarketsAysnc(Dictionary<string, string> params, string path)
        {
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                response = await response.Content.ReadAsAsync<params>();
            }
            return response;
        }

        // Get External Markets.
        /// <summary>
        /// Get External Markets.
        /// </summary>
        /// <returns>
        /// A Response Object. 
        /// </returns>
        /// /// <param name="params">A Dictonary Collection</param>
        /// /// <param name="path">A String</param>
        static aysnc Task<GetAllHotelIds> getlIdsAysnc(Dictionary<string, string> params, string path)
        {
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                response = await response.Content.ReadAsAsync<params>();
            }
            return response;
        }
        // Get Images
        /// <summary>
        /// Get Images
        /// </summary>
        /// <returns>
        /// A Response Object. 
        /// </returns>
        /// /// <param name="params">A Dictonary Collection</param>
        /// /// <param name="path">A String</param>
        static aysnc Task<GetHotelImages> getImagesAysnc(Dictionary<string, string> params)
        {
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                response = await response.Content.ReadAsAsync<params>();
            }
            return response;
        }
        // Get Profile by Id.
        /// <summary>
        /// Get Profile by Id.
        /// </summary>
        /// <returns>
        /// A Response Object. 
        /// </returns>
        /// /// <param name="params">A Dictonary Collection</param>
        /// /// <param name="path">A String</param>
        static aysnc Task<GetHotelProfileByID> getProfileByIdAysnc(Dictionary<string, string> params)
        {
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                response = await response.Content.ReadAsAsync<params>();
            }
            return response;
        }
        // Get Locations.
        /// <summary>
        /// Get Locations.
        /// </summary>
        /// <returns>
        /// A Response Object. 
        /// </returns>
        /// /// <param name="params">A Dictonary Collection</param>
        /// /// <param name="path">A String</param>
        static aysnc Task<GetHotelProfileByLocation> getLocationsAysnc(Dictionary<string, string> params)
        {
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                response = await response.Content.ReadAsAsync<params>();
            }
            return response;
        }

        // Get Rates.
        /// <summary>
        /// Get Rates.
        /// </summary>
        /// <returns>
        /// A Response Object. 
        /// </returns>
        /// /// <param name="params">A Dictonary Collection</param>
        /// /// <param name="path">A String</param>
        static aysnc Task<GetRates> getRatesAysnc(Dictionary<string, string> params)
        {
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                response = await response.Content.ReadAsAsync<params>();
            }
            return response;
        }

        // Search Hotels
        /// <summary>
        /// Search Hotels
        /// </summary>
        /// <returns>
        /// A Response Object. 
        /// </returns>
        /// /// <param name="params">A Dictonary Collection</param>
        /// /// <param name="path">A String</param>
        static aysnc Task<SearchHotels> searchHotelsAysnc(Dictionary<string, string> params)
        {
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                response = await response.Content.ReadAsAsync<params>();
            }
            return response;
        }
    }

        static async Task RunAsync()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("URL");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                var url = "";

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
}