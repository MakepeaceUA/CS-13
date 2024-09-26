using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class SeaCreature
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public string Habitat { get; set; }
        public SeaCreature(string name, string species, string habitat)
        {
            Name = name;
            Species = species;
            Habitat = habitat;
        }

        public override string ToString()
        {
            return $"{Name} ({Species}), обитает в {Habitat}.";
        }
    }
}
