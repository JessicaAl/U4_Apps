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
        public int id { get; set; }
        public string name { get; set; }
        public List<object> abilities { get; set; }
        public MainRegion main_region { get; set; }
        public List<Move> moves { get; set; }
        public List<Name> names { get; set; }
        public List<PokemonSpecy> pokemon_species { get; set; }
        public List<Type> types { get; set; }
        public List<VersionGroup> version_groups { get; set; }
    }
}
