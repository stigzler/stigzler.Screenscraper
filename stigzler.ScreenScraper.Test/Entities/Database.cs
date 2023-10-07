using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace stigzler.ScreenScraper.Test.Entities
{
    [Serializable]
    public class Database
    {
        public List<System> Systems { get; set; } = new List<System>();
        public List<GameMediaType> GameMediaTypes { get; set; } = new List<GameMediaType>();
        public List<Region> Regions { get; set; } = new List<Region>();


        //[XmlIgnore]
        public List<Game> Games { get; set; } = new List<Game>();


    }
}
