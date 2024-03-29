﻿using stigzler.Screenscraper.Data.Models;
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
    public class ApiUrlBuilder
    {
        public MetadataOutput MetadataOutputType { get; set; } = MetadataOutput.xml;
        public ApiCredentials Credentials { get; set; }
        public ApiServerParameters ServerParameters { get; set; }

        public ApiUrlBuilder(ApiCredentials credentials, ApiServerParameters serverParameters)
        {
            Credentials = credentials;
            ServerParameters = serverParameters;
        }

        public string Build(ApiQueryType queryType, List<QueryParameter> additionalParameters = null)
        {
            var build = new UriBuilder(ServerParameters.HostAddress);

            // Add Credentials and Server details
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
                    // HACK: the "-1" exclusion may not work in all scenarios. Depends on the parameter?
                    // Although, I can't think of an instance where a parameter would have -1 as a value...
                    if (parameter.Value != null && parameter.Value != "-1")
                    {
                        query[Constants.ApiQueryParameters[parameter.Parameter]] = Uri.EscapeDataString(parameter.Value); ;
                    }
                }
            }

            // Uri.EscapeDataString encodes parentheses as %2528/9 - screenscraper doesn't like this encoding in its Get queries
            build.Query = query.ToString().Replace("%2528", "(").Replace("%2529", ")");

            // -----------------
            return build.Uri.AbsoluteUri;

        }
    }
}
