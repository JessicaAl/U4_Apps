using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MemoramaAPIWeb.Models.PokeDatos;

namespace MemoramaAPIWeb.Models
{
    public class Pokemon
    {
        public List<GameIndice> game_indices { get; set; }
        public int height { get; set; }
        public List<Move> moves { get; set; }
        public string name { get; set; }
        public int order { get; set; }

    }
}
