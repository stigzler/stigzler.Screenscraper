using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace stigzler.Screenscraper.ModifiedNet
{
    internal class WebClient: System.Net.WebClient
    {
        /// <summary>
        /// Timeout to apply in milliseconds
        /// </summary>
        public int Timeout { get; set; } = 5000;
        public WebRequest WebRequest { get; set; } 

        public WebClient()
        {
            
        }

        public WebClient(int timeout)
        {
            Timeout = timeout;
        }

        protected override WebRequest GetWebRequest(Uri address)
        {
            WebRequest = base.GetWebRequest(address);
            WebRequest.Timeout = Timeout;
            return WebRequest;
        }


    }
}
