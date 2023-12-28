using stigzler.Screenscraper.Data.Entities;
using stigzler.Screenscraper.Data.Models;
using stigzler.Screenscraper.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace stigzler.Screenscraper.Data
{
    public static class GetDataObjects
    {
        // ToDo: haven't covered all lists - need to update data objects and Constants.QueryTypeElementName

        /// <summary>
        /// Returns standard lists for various query types. 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="queryType"></param>
        /// <param name="apiCredentials"></param>
        /// <param name="apiServerParameters"></param>
        /// <returns></returns>
        public static List<T> GetList<T>(ApiCredentials apiCredentials = null, ApiServerParameters apiServerParameters = null)
        {
            Enums.ApiQueryType queryType = Enums.ApiQueryType.None;
            switch (true)
            {
                case true when typeof(T) == typeof(Language):
                    queryType = Enums.ApiQueryType.LanguageList; break;
                case true when typeof(T) == typeof(Region):
                    queryType = Enums.ApiQueryType.RegionList; break;
                case true when typeof(T) == typeof(Genre):
                    queryType = Enums.ApiQueryType.GenreList; break;
                case true when typeof(T) == typeof(Data.Entities.System):
                    queryType = Enums.ApiQueryType.SystemList; break;

                // ToDo: Finish this list
                default:
                    break;
            }


            if (!Constants.QueryTypeElementName.ContainsKey(queryType))
            {
                throw new GetListObjectsException()
                {
                    ApiQueryType = queryType,
                    Error = "This query type does not work with this method"
                };
            }

            List<T> returns = new List<T>();

            if (apiCredentials == null) apiCredentials = Constants.DummyApiCredentials;
            if (apiServerParameters == null) apiServerParameters = Constants.StandardApiServerParameters;

            GetData getData = new GetData(apiCredentials, apiServerParameters);
            var outcome = getData.GetListOrInfo(queryType);

            XDocument xdoc = XDocument.Parse(outcome.Data.ToString());

            foreach (var element in xdoc.Descendants(Constants.QueryTypeElementName[queryType]))
            {
                var obj = (T)Activator.CreateInstance(typeof(T), element);
                returns.Add(obj);
            }

            return returns;
        }








    }
}
