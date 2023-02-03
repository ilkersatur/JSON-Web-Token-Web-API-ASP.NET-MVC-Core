using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(string username, string password)
        {
            var obj= new { Username=username, Password=password };

            HttpClient client = new HttpClient();
            var result = await client.PostAsJsonAsync("https://localhost:7264/api/Guvenli",obj);
            string token = result.Content.ReadAsStringAsync().Result;


            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            string json = await client.GetStringAsync("https://localhost:7264/api/Guvenli");
            //return Content(json);
            
            List<Urun> urunler= JsonConvert.DeserializeObject<List<Urun>>(json);
            return View("SonucGoster",urunler);
        }

        public IActionResult SonucGoster()
        {

            return View();
        }
    }
}
