using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace stigzler.Screenscraper.Data.Models
{
    /// <summary>
    /// API query results. This provides a data object to the consumer which holds details
    /// of the outcome of any API Get calls. 
    /// </summary>
    public class ApiGetOutcome
    {
        /// <summary>
        /// The Query Uri used
        /// </summary>
        public Uri Uri;
        /// <summary>
        /// This varies depending on the <c cref="Enums.ApiQueryGroup">ApiQueryGroup</c>:
        /// <list type = "table">
        ///    <listheader>
        ///        <term>Type</term>
        ///       <description> description </description>
        ///    </listheader>
        ///    <item>
        ///        <term cref="Enums.ApiQueryGroup.InfoAndLists">Enums.ApiQueryGroup.InfoAndLists</term>
        ///        <description>Data is the xml/json returned by the API</description>
        ///    </item>
        ///    <item>
        ///        <term cref="Enums.ApiQueryGroup.Downloads">Enums.ApiQueryGroup.Downloads</term>
        ///       <description>This returns the successful filename if the API Success = true.
        /// Otherwise, it returns the html text that helps with understanding the problem. 
        ///       </description>
        ///    </item>
        /// </list>
        /// </summary>
        public object Data;
        /// <summary>
        /// Returns whether the operation is successful. The definition of success varies by
        /// query type. 
        /// <example>E.g. a successful GameImageDownload if that the file was found and downloaded.
        /// A successful GameRomSearch is if a match was found. 
        /// </example>
        /// </summary>
        public bool Successfull = false;
        /// <summary>
        /// The http status code that results from the query. -1 means error wasn't from a HttpError
        /// </summary>
        public int StatusCode = -1;
        /// <summary>
        /// If an exception is raised from the query, it is returned via this property
        /// </summary>
        public Exception Exception = null; // only populated on any errors making the WebRequest
    }
}
