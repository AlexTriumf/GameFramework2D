using GameFramework.Factory;
using GameFramework.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Creature
{
    public class BeastFactory : CreatureFactory
    {

        public override ICreature CreateCreature()
        {

            return new Creature("BeastMaster", 10, 5, "Master of the woods", true, 100, new Position(1,1), null);
        }
    }
}
