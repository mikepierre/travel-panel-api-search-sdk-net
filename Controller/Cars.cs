using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using POCO.Cars;

namespace Controller.Cars
{
    public class Cars
    {
        static HttpClient client = new HttpClient();

        static aysnc Task<Book> book()
        {

        }

        static aysnc Task<Cancel> cancel(){}

        static aysnc Task<GetCarAvaiability> locations(){}

        static aysnc Task<GetLocataions> rates(){}
    }
}