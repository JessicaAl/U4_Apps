using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MemoramaAPIWeb.Models
{
    public class PokeDatos
    {


        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class MainRegion
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Move
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Language
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Name
        {
            public string name { get; set; }
            public Language language { get; set; }
        }

        public class PokemonSpecy
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Type
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class VersionGroup
        {
            public string name { get; set; }
            public string url { get; set; }
        }



    }
}
