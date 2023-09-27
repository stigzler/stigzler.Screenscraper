﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stigzler.ScreenScraper.Test.Entities
{
    [Serializable]
    public class System
    {
        public System()
        {
            
        }

        // Screenscraper Info
        public int ID { get; set; } 
        public string Name { get; set; } //EU Name

        // Info for Test App
        public string RomFolder { get; set; } 

    }
}
