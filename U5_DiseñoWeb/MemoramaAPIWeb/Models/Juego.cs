using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemoramaAPIWeb.Models
{
    public class Juego
    {
        public int idPoke { get; set; }
        public string Foto { get; set; }
        public string reversoCarta { get; set; }

        public bool isSelected { get; set; }

    }
}
