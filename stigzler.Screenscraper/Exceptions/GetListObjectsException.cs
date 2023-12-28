using stigzler.Screenscraper.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stigzler.Screenscraper.Exceptions
{
    public class GetListObjectsException: Exception
    {
        public ApiQueryType ApiQueryType { get; set; }
        public string ElementName { get; set; }

        public string Error { get; set; }

    }
}
