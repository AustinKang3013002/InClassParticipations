using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAPI
{
    class PokemonAPIResults
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<AllPokemonresult> results { get; set; }



    }
    public class AllPokemonresult
    {
        public string name { get; set; }
        public string url { get; set; }
        public string image { get; set; }
        public override string ToString()
        {
            return name;
        }
    }
}
