using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace stigzler.Screenscraper.Data.Models
{
    public class ApiGetOutcome
    {
        public string Url;
        public object Data;
        public bool Successfull = false;
        public HttpStatusCode HttpStatus;
        public Exception Exception = null;

    
    }
}
