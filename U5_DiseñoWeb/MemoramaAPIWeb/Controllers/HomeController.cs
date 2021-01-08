using MemoramaAPIWeb.Models;
using MemoramaAPIWeb.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MemoramaAPIWeb.Controllers
{
    public class HomeController : Controller
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

        public int IdRandom()
        {
            Random r = new Random();
            int rId = r.Next(1, 7);
            return rId;
        }
        private async Task<List<Pokemon>> GetListPokemon()
        {

            var i = 0;
            while (i < 7)
            {
                var id = IdRandom();
                client = Factory.CreateClient("Pokemones");
                var response = await client.GetAsync($"api/v2/pokemon?limit={id}");

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var des = JsonConvert.DeserializeObject<Pokemon>(json);
                    lstPokemon.Add(des);
                    i++;
                }
            }







            return lstPokemon;
        }

        public async Task<IActionResult> Memorama()
        {
            MemoViewModel mvm = new MemoViewModel();
            mvm.ListaPokemones = await GetListPokemon();

            return View("Index");
        }

        public IActionResult Reiniciar()
        {

            return RedirectToAction("Index");
        }
    }
}
