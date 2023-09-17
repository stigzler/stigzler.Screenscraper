using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stigzler.Screenscraper.EventArgs
{
    public class ProgressChangedEventArgs: System.EventArgs
    {
        /// <summary>
        /// Percentage progress of precessed to total objects
        /// </summary>
        public int ProgressPercentage { get; set; }

        /// <summary>
        /// The number of objects per second
        /// </summary>
        public double Rate { get; set; }  // this gives the operations per second

        /// <summary>
        /// The linked URI
        /// </summary>
        public Uri Uri { get; set; }

        /// <summary>
        /// Detail of the data object being proceeded. E.g. RomFilename or GameName
        /// </summary>
        public string DataObject { get; set; } 

    }
}
