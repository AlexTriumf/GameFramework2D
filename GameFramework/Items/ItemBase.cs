using GameFramework.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Items
{
    public abstract class ItemBase : IItem
    {
        public abstract string Name { get; }
        public abstract string Description { get; }

    }
}
