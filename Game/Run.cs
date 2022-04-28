using GameFramework;
using GameFramework.Creature;
using GameFramework.Entity;
using GameFramework.Factory;
using GameFramework.Interface;
using GameFramework.Items.Defense;
using GameFramework.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Game
{
    public class Run
    {
        private TraceSource ts = new TraceSource("Game Demo");
        List<Creature> list = new List<Creature>();
        List<WorldObject> inv = new List<WorldObject>();
        public void Start()
        {
            Log log = new Log(ts);



            CreatureFactory Beast = new BeastFactory();
            Beast.CreateCreature();
            Console.WriteLine(Beast.CreateCreature().Name.ToString());
            Console.WriteLine(Beast.CreateCreature().Description.ToString());
            Console.WriteLine(Beast.CreateCreature().HitPoints.ToString());

            ItemFactory ItemFactory = new ItemFactory(ts);
            var item = ItemFactory.ForgeItem(GameFramework.Enums.ItemCategory.Watch);
            Console.WriteLine(item.Name);

            WeaponFactory WeaponFactory = new WeaponFactory(ts);
            var weapon = WeaponFactory.ForgeWeapon(GameFramework.Enums.ItemCategory.Tresher);
            Console.WriteLine(weapon.Name);
            Console.WriteLine(weapon.Description);
            var pos = Configuration.GetInstance().LoadConfiguration();
            Console.WriteLine(pos);
        }

        





        
    }
}
