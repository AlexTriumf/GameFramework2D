using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Items.Weapon
{
    public class Bow : WeaponBase
    {
        public override int Damage => 8;

        public override string Name => "Amazon bow";

        public override string Description => "Amazon bow uses magic arrows +8 damage";
    }
}
