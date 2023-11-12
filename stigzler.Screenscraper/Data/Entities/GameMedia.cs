using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using stigzler.Screenscraper.Enums;

namespace stigzler.Screenscraper.Data.Entities
{
    public class GameMedia
    {
        public MediaCategory MediaCategory { get; set; }
        public GameMediaType MediaType { get; set; }


        /// <summary>
        /// This is used with the Genre media type.
        /// </summary>
        public int AssociatedId { get; set; }

        public string Region { get; set; }
        public string CRC { get; set; }
        public string MD5 { get; set; }
        public string SHA1 { get; set; }
        public Int32 Size { get; set; }
        public string Format { get; set; }
        public string Uri { get; set; }

        /// <summary>
        /// Not sure what this is, but in for completeness...
        /// </summary>
        public int Support { get; set; }    


    }
}
