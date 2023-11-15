using stigzler.Screenscraper.Data.Entities;
using stigzler.Screenscraper.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace stigzler.Screenscraper.Data
{
    public static class DefaultData
    {

        public static List<Genre> GetGenres(ApiCredentials apiCredentials = null, ApiServerParameters apiServerParameters = null)
        {
            List<Genre> returns = new List<Genre>();

            if (apiCredentials == null) apiCredentials = Constants.DummyApiCredentials;
            if (apiServerParameters == null) apiServerParameters = Constants.StandardApiServerParameters;

            GetData getData = new GetData(apiCredentials, apiServerParameters);
            var outcome = getData.GetListOrInfo(Enums.ApiQueryType.GenreList);

            XDocument xdoc = XDocument.Parse(outcome.Data.ToString());
            
            foreach (var genre in xdoc.Descendants("genre"))
            {
                returns.Add(new Genre(genre));
            }       

            return returns;
        }






    }
}
