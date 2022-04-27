using GameFramework.Enums;
using GameFramework.Interface;
using GameFramework.Items.Defense;
using GameFramework.Items.Utilities;
using GameFramework.Items.Weapon;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Factory
{
    public class ItemFactory : IItemFactory
    {
        /// <summary>
        /// Create factory for a item category
        /// </summary>
        /// <param name="ts"></param>
       
        public IItem ForgeItem(ItemCategory category)
        {
            TraceSource ts = new TraceSource("Game");
            ts.Switch = new SourceSwitch("Item Factory", "All");

           
            switch (category)
            {
                case ItemCategory.Watch: return new Watch();
               
            }
            return null;
        }
        
    }
}
