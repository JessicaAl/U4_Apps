using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MemoramaAPIWeb.Models.PokeDatos;
using Type = MemoramaAPIWeb.Models.PokeDatos.Type;

namespace MemoramaAPIWeb.Models
{
    public class Pokemon
    {
        public int idPoke { get; set; }
        public string Foto { get; set; }
        public string reversoCarta { get; set; }
        public bool isSelected { get; set; }
    }
}
