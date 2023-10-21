using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace stigzler.Screenscraper.ModifiedNet
{

    [System.ComponentModel.DesignerCategory("Code")]
    internal class WebClient : System.Net.WebClient
    {
        /// <summary>
        /// Timeout to apply in milliseconds
        /// </summary>
        internal int Timeout { get; set; } = 5000;
        internal WebRequest WebRequest { get; set; }

        internal WebClient()
        {

        }

        internal WebClient(int timeout)
        {
            Timeout = timeout;
        }

        protected override WebRequest GetWebRequest(Uri address)
        {
            WebRequest w = base.GetWebRequest(address);
            w.Timeout = Timeout;
            return w;
        }

    }
}
