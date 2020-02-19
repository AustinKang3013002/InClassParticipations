using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAPI
{
    class PokemonAPI
    {
        public int height { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int weight { get; set; }
        public Sprite sprites { get; set; }

    }

    public class Sprite
    {
        public string FrontDefault { get; set; }
        public string BackDefault { get; set; }
    }
}
