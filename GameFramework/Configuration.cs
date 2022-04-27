using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace GameFramework
{
    public sealed class Configuration
    {
        TraceSource ts = new TraceSource("GameFramework");
        /// <summary>
        /// Singleton
        /// </summary>
       private Configuration()
        {

        }
        private static Configuration _instance;

        public static Configuration GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Configuration();
            }
            return _instance;
        }
      /// <summary>
      /// Returns URL of main directory and loads the config file using LINQ. Adds the position tolist
      /// </summary>
      /// <returns></returns>
        public List<int> LoadConfiguration()
        {
            ts.Switch = new SourceSwitch("Load Configuration", "All");
            ts.TraceEvent(TraceEventType.Information, 1, "Load config file");
            XmlDocument xmlDoc = new XmlDocument();
            // returns url of main directory which contains "/bin/Debug"
            var dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly
                .GetExecutingAssembly().GetName().CodeBase);
            //correction in path to point it in Root directory
            var mainpath = dir.Replace("\\bin\\Debug", "") + "\\config.xml";

            XDocument document = XDocument.Load(mainpath);
            List<Position> poslist = new List<Position>();
            var result = document.Element("position").Elements("key").Select(x => (int)x.Attribute("value"));
            var q = (from elements in document.Elements("position").Elements("key").Elements("value") select (int)elements).ToList();
            return q;

        }
         
    }
}
