using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using POCO.Transfers;

namespace Controller.Transfers
{
    public class Transfers
    {
        static HttpClient client = new HttpClient();

        // Book Transfer
        /// <summary>
        /// Book Transfer
        /// </summary>
        /// <returns>
        /// A Response Object. 
        /// </returns>
        /// /// <param name="params">A Dictonary Collection</param>
        /// /// <param name="path">A String</param>
        static aysnc Task<Book> book()
        {
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                response = await response.Content.ReadAsAsync<params>();
            }
            return response;
        }

        // Get Report By Id
        /// <summary>
        /// Get Report By Id
        /// </summary>
        /// <returns>
        /// A Response Object. 
        /// </returns>
        /// /// <param name="params">A Dictonary Collection</param>
        /// /// <param name="path">A String</param>
        static aysnc Task<GetTransferAvailablity> getRates()
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