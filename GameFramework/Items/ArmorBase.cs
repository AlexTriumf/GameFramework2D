using GameFramework.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Items
{
    public abstract class ArmorBase : IItem, IArmor
    {
       public abstract int ReduceDamage { get; }
       public abstract string Name { get; }
       public abstract string Description { get; }
    }
}
