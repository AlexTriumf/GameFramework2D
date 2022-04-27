using GameFramework.Creature;
using GameFramework.Factory;
using System;
using GameFramework;
using GameFramework.Logging;
using System.Diagnostics;

namespace Game
{
    public class Program
    {
        private TraceSource ts = new TraceSource("Game Demo");
        static void Main(string[] args)
        {
            Run r = new Run();
            r.Start();
        }

       
    }
}
