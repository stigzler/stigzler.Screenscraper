using stigzler.Screenscraper.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stigzler.Screenscraper.Helpers
{
    public class QueryParameter
    {

        public QueryParameter(ApiQueryParameter queryParameter, string value)
        {
            Parameter = queryParameter;
            Value = value;
        }

        public QueryParameter()
        {
            
        }
        public ApiQueryParameter Parameter { get; set; }
        public string Value { get; set; }

    }
}
