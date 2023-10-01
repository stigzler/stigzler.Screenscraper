using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stigzler.ScreenScraper.Test.Entities
{
    [Serializable]
    public class Game
    {

        // Screenscraper Info
        public int ID { get; set; }
        public int SystemID { get; set; }
        public string Name { get; set; } //EU Name
        public string MainRomFilename { get; set; }

        // Info for Test App
        public string GameXml { get; set; }



    }
}
