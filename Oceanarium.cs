using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Oceanarium : IEnumerable<SeaCreature>
    {
        List<SeaCreature> creatures = new List<SeaCreature>();

        public void AddCreature(SeaCreature creature)
        {
            creatures.Add(creature);
        }

        public IEnumerator<SeaCreature> GetEnumerator()
        {
            for (int i = 0; i < creatures.Count; i++)
            {
                yield return creatures[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
