using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Items.Defense
{
    public class Helm : ArmorBase
    {
        public override int ReduceDamage => 10;

        public override string Name => "Iron Helm";

        public override string Description => "Iron help keeps the head safe. 10+ Damage reduction";
    }
}
