using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Entity
{
    public class WorldObject
    {
        public string Name { get; set; }
        public bool Lootable { get; set; }
        public bool Removeable { get; set; }

        public WorldObject(string name, bool lootable, bool removeable)
        {
            Name = name;
            Lootable = lootable;
            Removeable = removeable;
        }
        public WorldObject()
        {

        }
    }
}
