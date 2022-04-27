using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Items.Defense
{
    public class Boots : ArmorBase
    {
        public override int ReduceDamage => 10;

        public override string Name => "Scarabshell boots";

        public override string Description => "Combat boots. Adds 10 damage reduction";
    }
}
