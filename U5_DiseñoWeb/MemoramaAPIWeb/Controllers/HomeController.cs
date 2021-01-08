using MemoramaAPIWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MemoramaAPIWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        public IHttpClientFactory Factory { get; set; }
        HttpClient client;
        public HomeController(IHttpClientFactory clientFactory)
        {
            Factory = clientFactory;
        }

        public List<Pokemon> lstPokemon { get; set; } = new List<Pokemon>();

        public IActionResult Index()
        {
            return View();
        }

    }
}
