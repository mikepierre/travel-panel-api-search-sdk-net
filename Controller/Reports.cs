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

        static aysnc Task<GetAllReservations> myReservations()
        {

        }

        static aysnc Task<GetReportById> getReportById(){}

        static aysnc Task<GetReportsByUserId> getReportByUserId(){}
    }
}