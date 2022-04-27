using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Items.Weapon
{
    public class Spear : WeaponBase
    {
        public override int Damage => 11;

        public override string Name => "Amazon Spear";

        public override string Description => "Amazon spear gives +11 damage";
    }
}
