using stigzler.Screenscraper.Data.Models;
using stigzler.Screenscraper.Enums;
using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using stigzler.Screenscraper.Data;
using System.IO;
using System.Reflection.Emit;

namespace stigzler.Screenscraper.Helpers
{
    internal class ApiUrlBuilder
    {
        public MetadataOutput MetadataOutputType { get; set; } = MetadataOutput.xml;
        public Credentials Credentials { get; set; }
        public ApiServerParameters ServerParameters { get; set; }

        public ApiUrlBuilder(Credentials credentials, ApiServerParameters serverParameters)
        {
            Credentials = credentials;
            ServerParameters = serverParameters;
        }

        internal string Build(ApiQueryType queryType, List<QueryParameter> additionalParameters = null)
        {
            var build = new UriBuilder(ServerParameters.HostAddress);

            // Add Credentials and Server details
            build.Port = (int)ServerParameters.HostPort;
            build.Path = Path.Combine(ServerParameters.ApiPath, Constants.ApiQueryPaths[queryType]);
            var query = HttpUtility.ParseQueryString(build.Query);
            query["devid"] = Credentials.DeveloperID;
            query["devpassword"] = Credentials.DeveloperPassword;
            query["softname"] = Credentials.DeveloperSoftware;
            query["ssid"] = Credentials.UserID;
            query["sspassword"] = Credentials.UserPassword;
            query["output"] = MetadataOutputType.ToString();

            // Now process any extra parameters
            if (additionalParameters != null)
            {
                foreach (QueryParameter parameter in additionalParameters)
                {
                    query[Constants.ApiQueryParameters[parameter.Parameter]] = Uri.EscapeDataString(parameter.Value);
                }
            }

            build.Query = query.ToString();

            // -----------------
            return build.Uri.AbsoluteUri;

        }
    }
}
