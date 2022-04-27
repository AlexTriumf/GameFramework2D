using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Items.Defense
{
    public class Armor : ArmorBase
    {
        public override int ReduceDamage => 5;

        public override string Name => "Chainmail";

        public override string Description => "Chainmail to keep your body safe";
    }
}
