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
        public List<Position> LoadConfiguration()
        {
            ts.Switch = new SourceSwitch("Load Configuration", "All");
            ts.TraceEvent(TraceEventType.Information, 1, "Load config file");

            // returns url of main directory which contains "/bin/Debug"
            var dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly
                .GetExecutingAssembly().GetName().CodeBase);
            //correction in path to point it in Root directory
            var mainpath = dir.Replace("\\bin\\Debug\\net5.0", "") + "\\config.xml";

            XDocument document = XDocument.Load(mainpath);
            List<Position> poslist = new List<Position>();
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(mainpath);

            poslist = document.Descendants("POSITION")
            .Select(p => new Position()
            {
                X = Convert.ToInt16(p.Element("XPOS").Attribute("value")?.Value),
                Y = Convert.ToInt16(p.Element("YPOS").Attribute("value")?.Value)
            }).ToList();


            return poslist;


        }
    }
}
