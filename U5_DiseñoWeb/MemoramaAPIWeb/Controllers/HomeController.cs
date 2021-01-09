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

        private async Task<List<Pokemon>> GetListPokemon()
        {
            Random r = new Random();
            int rId = r.Next(1, 7);
            var i = 0;
                var id = rId;
                client = Factory.CreateClient("Pokemones");
                var response = await client.GetAsync($"api/v2/pokemon?limit={id}");

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var des = JsonConvert.DeserializeObject<Pokemon>(json);
                    lstPokemon.Add(des);
                    i++;
                }
            return lstPokemon;
        }

        public List<Juego> ListaCartas { get; set; } = new List<Juego>();

        public async Task<IActionResult> Memorama()
        {
            MemoViewModel mvm = new MemoViewModel();
            mvm.ListaPokemones = await GetListPokemon();

            Random r = new Random();
            int[] idsPoke = new int[12] { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6 };

            for (int i = 0; i <= 11; i++)
            {
                var p = r.Next(0, 12);
                var q = idsPoke[i];
                idsPoke[i] = idsPoke[p];
                idsPoke[p] = q;
            }

            for (int i = 0; i <= idsPoke.Length; i++)
            {
                mvm.poke.Foto = $"~/images/{idsPoke[i]}.jpg";
                mvm.poke.idPoke = idsPoke[i];
                mvm.poke.isSelected = false;
                mvm.poke.reversoCarta = "~/images/reversoCarta.jpg";

                mvm.ListaPokemones.Add(mvm.poke);
            }






            return View("Index");
        }

        public IActionResult Reiniciar()
        {

            return RedirectToAction("Index");
        }
    }
}
