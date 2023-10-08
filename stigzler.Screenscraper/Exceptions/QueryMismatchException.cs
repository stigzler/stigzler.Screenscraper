using stigzler.Screenscraper.Data;
using stigzler.Screenscraper.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stigzler.Screenscraper.Exceptions
{
    public class QueryMismatchException : Exception
    {
        public QueryMismatchException(ApiQueryType attemptedQueryType, ApiQueryGroup correctGroup)
        {
            AttemptedQueryType = attemptedQueryType;
            CorrectGroup = correctGroup;
            AcceptedQueryTypes = Constants.ApiQueryGroups[correctGroup];
        }

        /// <summary>
        /// The attempted query type.
        /// </summary>
        public ApiQueryType AttemptedQueryType { get; set; }

        /// <summary>
        /// The group that permitted query types belongs to.
        /// </summary>
        public ApiQueryGroup CorrectGroup { get; set; }
        /// <summary>
        /// List of permitted query types.
        /// </summary>
        public List<ApiQueryType> AcceptedQueryTypes { get; set; }

    }
}
