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


        [XmlIgnore]
        public List<Game> Games { get; set; } = new List<Game>();

        public List<GameMediaType> GameMediaTypes { get; set; } = new List<GameMediaType>();

    }
}
