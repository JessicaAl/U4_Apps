using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemoramaAPIWeb.Models.ViewModels
{
    public class MemoViewModel
    {
        public List<Pokemon> ListaPokemones { get; set; }

        public Juego poke1 { get; set; } = new Juego();
        public Juego poke2 { get; set; } = new Juego();
        public Juego poke3 { get; set; } = new Juego(); 
        public Juego poke4 { get; set; } = new Juego();
        public Juego poke5 { get; set; } = new Juego();
        public Juego poke6 { get; set; } = new Juego();

        
    }
}
