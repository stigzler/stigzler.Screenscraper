using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stigzler.Screenscraper.Data.Models
{
    /// <summary>
    /// User credentials for use with the ScreenScraper API
    /// </summary>
    public class ApiCredentials
    {
        /// <summary>
        /// The Api Developer ID
        /// </summary>
        public string DeveloperID { get; set; }
        /// <summary>
        /// The Api Developer Password
        /// </summary>
        public string DeveloperPassword { get; set; }
        /// <summary>
        /// The ApiKey Developer Software Name
        /// </summary>
        public string DeveloperSoftware { get; set; }
        /// <summary>
        /// The ScreenScraper User ID
        /// </summary>
        public string UserID { get; set; }
        /// <summary>
        /// The ScreenScraper User Password
        /// </summary>
        public string UserPassword { get; set; }

    }
}
