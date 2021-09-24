using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
           var data = Fetching.GetDataFromHttp().GetAwaiter().GetResult();
           foreach(var Courses in data)
           {
               Console.WriteLine(Courses);
           }
        }
    }
}
