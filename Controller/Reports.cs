using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using POCO.Reports;

namespace Controller.Reports
{
    public class Reports
    {
        static HttpClient client = new HttpClient();

        // Get My Reservations
        /// <summary>
        /// Get My Reservations
        /// </summary>
        /// <returns>
        /// A Response Object. 
        /// </returns>
        /// /// <param name="params">A Dictonary Collection</param>
        /// /// <param name="path">A String</param>
        static aysnc Task<GetAllReservations> myReservations(Dictionary<string, string> param)
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
        static aysnc Task<GetReportById> getReportById()
        {
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                response = await response.Content.ReadAsAsync<params>();
            }
            return response;
        }

        // Get Report By User ID
        /// <summary>
        /// Get Report By User ID
        /// </summary>
        /// <returns>
        /// A Response Object. 
        /// </returns>
        /// /// <param name="params">A Dictonary Collection</param>
        /// /// <param name="path">A String</param>
        static aysnc Task<GetReportsByUserId> getReportByUserId()
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