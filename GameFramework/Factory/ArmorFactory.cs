using GameFramework.Enums;
using GameFramework.Interface;
using GameFramework.Items.Defense;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Factory
{
    public class ArmorFactory : IArmorFactory
    {
        /// <summary>
        /// Create factory for a item category
        /// </summary>
        /// <param name="ts"></param>
       
        public IItem ForgeArmor(ItemCategory category)
        {
            switch (category)
            {
                case ItemCategory.Armor: return new Armor();
                case ItemCategory.Helm: return new Helm();
                case ItemCategory.Belt: return new Belt();
                case ItemCategory.Boots: return new Boots();

              
            }
            return null;
        }
        public IItem ForgeArmor(ItemCategory category, TraceSource ts)
        {
            switch (category)
            {
                case ItemCategory.Armor: return new Armor();
                case ItemCategory.Helm: return new Helm();
                case ItemCategory.Belt: return new Belt();
                case ItemCategory.Boots: return new Boots();


            }
            return null;
        }
    }
}
