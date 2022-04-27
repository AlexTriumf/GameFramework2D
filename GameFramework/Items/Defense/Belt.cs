using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Items.Defense
{
    public class Belt : ArmorBase
    {
        public override int ReduceDamage => 5;

        public override string Name => "Belt";

        public override string Description => "The belt of verdingo. Stats: 5 Damage Reduction";
    }
}
