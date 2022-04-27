using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Items.Weapon
{
    public class Tresher : WeaponBase
    {
        /// <summary>
        /// Weapon item. Intial idea was to use state for grim reaper powers
        /// </summary>

        public override string Name => "Legendary Tresher";

        public override string Description => "Whoever wields the tresher will become the Grim Reaper";

        public override int Damage => 99;
    }
}
