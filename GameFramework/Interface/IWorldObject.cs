using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Interface
{
    public interface IWorldObject
    {
        string Name { get; set; }
        bool Lootable { get; set; }
        bool Removeable { get; set; }
    }
}
