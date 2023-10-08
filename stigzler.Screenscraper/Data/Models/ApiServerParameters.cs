using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stigzler.Screenscraper.Data.Models
{
    public class ApiServerParameters
    {
        /// <summary>
        /// This sets the timeout for the web request in milliseconds.
        /// </summary>
        public int HttpTimeout { get; set; } = 5000;
        /// <summary>
        /// The base address of the screenscraper API.
        /// <example>Example: "https://www.screenscraper.fr"</example>
        /// </summary>
        public string HostAddress { get; set; } = @"https://www.screenscraper.fr";

        //public int HostPort { get; set; } = -1;
        /// <summary>
        /// The path to the api from the HostAddress.
        /// <example>Example: "api2"</example>
        /// </summary>
        public string ApiPath { get; set; } = @"api2";      

    }
}
