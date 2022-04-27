using GameFramework.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Items
{
    public abstract class WeaponBase : IItem, IWeapon
    {
        /// <summary>
        /// Superclass weapon class
        /// </summary>
        public abstract int Damage { get; }
        public abstract string Name { get; }
        public  abstract string Description { get; }

    
    }
}
