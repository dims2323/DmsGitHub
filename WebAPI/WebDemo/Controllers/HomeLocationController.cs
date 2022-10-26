using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using WebDemo.Models;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace WebDemo.Controllers
{
    public class HomeLocationController : Controller
    {
        public async Task<IActionResult> Index()
        {
            IEnumerable<Country> _country = null;

            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:44354/api/location/country");

            var webapi = httpClient.GetAsync("Location");
            webapi.Wait();

            var readdata = webapi.Result;
            if(readdata.IsSuccessStatusCode)
            {
                var datadisplay = await readdata.Content.ReadAsStreamAsync();

                _country = await JsonSerializer.DeserializeAsync<IEnumerable<Country>>(datadisplay);
                //_country = datadisplay.Result;
            }

            return View(_country);
        }
    }
}
