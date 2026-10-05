using System;

namespace Biosz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bird e = new Eagle(4);
            List<ICreature> creatures = new List<ICreature> { e };
            AppleTree alma = new AppleTree(50);
            creatures.Add(alma);
            foreach (ICreature creature in creatures)
            {
                creature.Reproduce();
            }
        }
    }
}