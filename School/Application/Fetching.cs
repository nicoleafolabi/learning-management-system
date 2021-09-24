using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Application
{
    public record CourseName(string name);
    
    public class Fetching
    {
        public static async Task<List<CourseName>> GetDataFromHttp()
        {
            var client = new HttpClient();
            var jsonTask = client.GetFromJsonAsync<List<CourseName>>("https://raw.githubusercontent.com/chyld/datasets/main/subjects.json");
            await Task.WhenAll(jsonTask);

            if (jsonTask.Status != TaskStatus.RanToCompletion) throw new Exception("JSON Error");
            return (jsonTask.Result);
        }
    }
}
