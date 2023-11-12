using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using stigzler.Screenscraper.Enums;

namespace stigzler.Screenscraper.Data.Entities
{
    public class SystemMedia
    {
        public MediaCategory MediaCategory { get; set; }
        public SystemMediaType MediaType { get; set; }

        public string Region { get; set; }
        public string CRC { get; set; }
        public string MD5 { get; set; }
        public string SHA1 { get; set; }
        public string Format { get; set; }
        public string Uri { get; set; }

        /// <summary>
        /// Not sure what this is, but in for completeness...
        /// </summary>
        public int Support { get; set; }    


    }
}
