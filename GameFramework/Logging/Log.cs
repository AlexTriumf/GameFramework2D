using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Logging
{
    public class Log
    {
        public Log(TraceSource ts)
        {
            ts.Switch = new SourceSwitch("Game log", "All");

            TraceListener Log = new ConsoleTraceListener();
            Log.Filter = new EventTypeFilter(SourceLevels.All);
            ts.Listeners.Add(Log);

            TraceListener fileLog = new TextWriterTraceListener(new StreamWriter("Log.txt"));
            ts.Listeners.Add(fileLog);
        }
    }
}
