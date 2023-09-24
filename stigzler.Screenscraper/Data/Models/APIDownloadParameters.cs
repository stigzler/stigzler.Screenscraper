using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stigzler.Screenscraper.Data.Models
{
    public class APIDownloadParameters
    {
        /// <summary>
        /// CRC of the media file
        /// </summary>
        public string CRC { get; set; } = null;
        /// <summary>
        /// MD5 of the media file
        /// </summary>
        public string MD5 { get; set; } = null;
        /// <summary>
        /// SHA1 of the media file
        /// </summary>
        public string SHA1 { get; set; } = null;
        /// <summary>
        /// The name of the Media Item to download (e.g. "Wheel(wor)").
        /// </summary>
        public string MediaTypeName { get; set; } = null;
        /// <summary>
        /// Media format (e.g. "png")
        /// </summary>
        public string MediaFormat { get; set; } = null;

        /// <summary>
        /// SystemID of the related system
        /// </summary>
        public int SystemID { get; set; } = -1;
        /// <summary>
        /// ID of the relevant object. E.g. for GameImages query this would be the GameID. For GameOrganisationImages, the OrganisationID
        /// </summary>
        public int ObjectID { get; set; } = -1;


        
    }
}
