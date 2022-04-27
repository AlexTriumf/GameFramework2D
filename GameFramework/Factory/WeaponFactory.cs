using GameFramework.Enums;
using GameFramework.Interface;
using GameFramework.Items.Weapon;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Factory
{
    public class WeaponFactory : IWeaponFactory
    {
        /// <summary>
        /// Create factory for a weapon category
        /// </summary>
        /// <param name="ts"></param>
        
        public IItem ForgeWeapon(ItemCategory category)
        {
            TraceSource ts = new TraceSource("Game");
            ts.Switch = new SourceSwitch("Forge Weapon", "All");

            ts.TraceEvent(TraceEventType.Information, 33, "Weapon forged " + category.ToString());
            switch (category)
            {

                case ItemCategory.Axe: return new Axe();
                case ItemCategory.Bow: return new Bow();
                case ItemCategory.Spear: return new Spear();
                case ItemCategory.Tresher: return new Tresher();
            }
            return null;
        }
       
    }
}
