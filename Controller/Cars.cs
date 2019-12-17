using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using POCO.Cars;
using POCO.Cars.Book;

namespace Controller.Cars
{
    public class Cars
    {
        static HttpClient client = new HttpClient();

        // Post Book
        /// <summary>
        /// Post Book
        /// </summary>
        /// <returns>
        /// A Response Object. 
        /// </returns>
        /// /// <param name="params">A Dictonary Collection</param>
        /// /// <param name="path">A String</param>
        static void book()
        {
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                response = await response.Content.ReadAsAsync<params>();
            }
            return response;
        }

        // Cancel Car
        /// <summary>
        /// Cancel Car
        /// </summary>
        /// <returns>
        /// A Response Object. 
        /// </returns>
        /// /// <param name="params">A Dictonary Collection</param>
        /// /// <param name="path">A String</param>
        static aysnc Task<Cancel> cancel()
        {
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                response = await response.Content.ReadAsAsync<params>();
            }
            return response;
        }

        // Post Book
        /// <summary>
        /// Post Book
        /// </summary>
        /// <returns>
        /// A Response Object. 
        /// </returns>
        /// /// <param name="params">A Dictonary Collection</param>
        /// /// <param name="path">A String</param>
        static aysnc Task<GetLocataions> locations()
        {
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                response = await response.Content.ReadAsAsync<params>();
            }
            return response;
        }

        // Get Rates
        /// <summary>
        /// Get Rates
        /// </summary>
        /// <returns>
        /// A Response Object. 
        /// </returns>
        /// /// <param name="params">A Dictonary Collection</param>
        /// /// <param name="path">A String</param>
        static aysnc Task<GetCarAvaiability> rates()
        {
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                response = await response.Content.ReadAsAsync<params>();
            }
            return response;
        }
    }
}