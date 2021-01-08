using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemoramaAPIWeb.Models
{
    public class PokeDatos
    {
        public class Version
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class GameIndice
        {
            public int game_index { get; set; }
            public Version version { get; set; }
        }
        public class VersionGroupDetail
        {
            public int level_learned_at { get; set; }
            public MoveLearnMethod move_learn_method { get; set; }
            public VersionGroup version_group { get; set; }
        }


        public class Move2
        {
            public string name { get; set; }
            public string url { get; set; }
        }
        public class VersionGroup
        {
            public string name { get; set; }
            public string url { get; set; }
        }
        public class Move
        {
            public Move2 move { get; set; }
            public List<VersionGroupDetail> version_group_details { get; set; }
        }
        public class MoveLearnMethod
        {
            public string name { get; set; }
            public string url { get; set; }
        }

    }
}
