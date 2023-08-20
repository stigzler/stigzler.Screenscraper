using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stigzler.Screenscraper.Data.Models
{
    public class ApiServerParameters
    {
        public int HttpTimeout { get; set; } = 5000;
        public int FallbackHttpTimeout { get; set; } = 10000;
        public int HttpTimeoutRetries { get; set; } = 2;

        public string HostAddress { get; set; } = @"https://www.screenscraper.fr";
        public int HostPort { get; set; } = -1;
        public string ApiPath { get; set; } = @"api2";

       

    }
}
