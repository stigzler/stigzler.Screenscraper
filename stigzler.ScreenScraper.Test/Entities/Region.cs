using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stigzler.ScreenScraper.Test.Entities
{
    [Serializable]
    public class Region
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}
