using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Items.Weapon
{
    public class Axe : WeaponBase
    {
        public override int Damage => 15;

        public override string Name => "Broadaxe";

        public override string Description => "Doubleedged axe forged by the famous Khal Boran";
    }
}
