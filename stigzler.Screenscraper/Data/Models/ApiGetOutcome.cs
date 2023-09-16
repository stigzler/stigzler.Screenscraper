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
        public Uri Uri;
        public object Data;
        public bool Successfull = false;
        public int StatusCode = -1; // -1 means that the error wasn't from a HttpError
        public Exception Exception = null; // only populated on any errors making the WebRequest
    }
}
