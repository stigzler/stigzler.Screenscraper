using stigzler.Screenscraper.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Caching;
using System.Xml.Linq;

namespace stigzler.Screenscraper.Data.Entities
{
    public class User
    {
        public int ID { get; set; }

        public string Username { get; set; }

        public int UserLevelID { get; set; }

        public int ContributionLevel { get; set; }

        public int SystemMediaContributions { get; set; }

        public int MetadataContributions { get; set; }

        public int RomInfoContributions { get; set; }

        public int GameMediaContributions { get; set; }

        public int ValidProposals { get; set; }

        public int InvalidProposals { get; set; }
        public int ValidProposalPercentage { get; set; }

        public int MaxThreads { get; set; }

        public int MaxDownloadSpeed { get; set; }

        public int TotalRequestsToday { get; set; }

        public int UnsuccessfullRequestsToday { get; set; }

        public int MaxRequestsPerMinute { get; set; }

        public int MaxRequestsPerDay { get; set; }

        public int MaxUnsuccessfulRequestsPerDay { get; set; }

        public int UserVisits { get; set; }

        public DateTime LastVisit { get; set; }

        public string FavoriteRegion { get; set; }

        public User()
        {
            
        }

        public User(XElement rootElement)
        {
            UpdateFromXElement(rootElement);
        }

        public void UpdateFromXElement(XElement rootElement)
        {
            XElement userElement = rootElement.AncestorsAndSelf().First();

           //if (userElement != null) return;

            ID = Int32.Parse( userElement.TryGetElementValue("numid"));
            Username = userElement.TryGetElementValue("id");
            UserLevelID = Int32.Parse(userElement.TryGetElementValue("numid"));
            ContributionLevel = Int32.Parse(userElement.TryGetElementValue("contribution"));
            SystemMediaContributions = Int32.Parse(userElement.TryGetElementValue("uploadsysteme"));
            MetadataContributions = Int32.Parse(userElement.TryGetElementValue("uploadinfos"));
            RomInfoContributions = Int32.Parse(userElement.TryGetElementValue("romasso"));
            GameMediaContributions = Int32.Parse(userElement.TryGetElementValue("uploadmedia"));
            ValidProposals = Int32.Parse(userElement.TryGetElementValue("propositionok"));
            InvalidProposals = Int32.Parse(userElement.TryGetElementValue("propositionko"));
            ValidProposalPercentage = Int32.Parse(userElement.TryGetElementValue("quotarefu"));
            MaxThreads = Int32.Parse(userElement.TryGetElementValue("maxthreads"));
            MaxDownloadSpeed = Int32.Parse(userElement.TryGetElementValue("maxdownloadspeed"));
            TotalRequestsToday = Int32.Parse(userElement.TryGetElementValue("requeststoday"));
            UnsuccessfullRequestsToday = Int32.Parse(userElement.TryGetElementValue("requestskotoday"));
            MaxRequestsPerMinute = Int32.Parse(userElement.TryGetElementValue("maxrequestspermin"));
            MaxRequestsPerDay = Int32.Parse(userElement.TryGetElementValue("maxrequestsperday"));
            MaxUnsuccessfulRequestsPerDay = Int32.Parse(userElement.TryGetElementValue("maxrequestskoperday"));
            UserVisits = Int32.Parse(userElement.TryGetElementValue("visites"));
            FavoriteRegion = userElement.TryGetElementValue("favregion");

            string lastVisit = userElement.TryGetElementValue("datedernierevisite", null);
            if (lastVisit != null)
            {
                DateTime.TryParse(lastVisit, out DateTime dateReleased);
                if (dateReleased != DateTime.MinValue)
                {
                    LastVisit = dateReleased;
                }
            }           
            
        }

    }
}
