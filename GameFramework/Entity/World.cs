using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Entity
{
    public class World
    {
       public int MaxX { get; set; }
       public int MaxY { get; set; }

        public World(int maxX, int maxY)
        {
            MaxX = maxX;
            MaxY = maxY;
        }
    }
}
