using stigzler.Screenscraper.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using stigzler.Screenscraper.Enums;

namespace stigzler.Screenscraper.Data.Entities
{
    [Serializable]
    public class System
    {
        public int ID { get; set; }
        public string NameEurope { get; set; }
        public string NameUS { get; set; }
        public string NameRecalbox { get; set; }
        public string NameRetropie { get; set; }
        public string NameLaunchbox { get; set; }
        public string NameHyperspin { get; set; }
        public List<string> OtherNames { get; set; } = new List<string>();
        public List<string> Extensions { get; set; } = new List<string>();
        public string Developer { get; set; }
        public string Type { get; set; }
        public DateTime DateReleased { get; set; }
        public DateTime DateDiscontinued { get; set; }
        public RomFileType RomFileType { get; set; }
        public List<RomMediaType> RomMediaTypes { get; set; } = new List<RomMediaType>();
        public List<SystemMedia> MediaList { get; set; } = new List<SystemMedia>();

        public System()
        {

        }

        public System(XElement rootElement)
        {
            UpdateFromXElement(rootElement);
        }


        public void UpdateFromXElement(XElement rootElement)
        {
            ID = Int32.Parse(rootElement.Element("id").Value);

            // Names
            NameEurope = rootElement.Element("noms").TryGetElementValue("nom_eu");
            NameUS = rootElement.Element("noms").TryGetElementValue("nom_us");
            NameRecalbox = rootElement.Element("noms").TryGetElementValue("nom_recalbox");
            NameRetropie = rootElement.Element("noms").TryGetElementValue("nom_retropie");
            NameLaunchbox = rootElement.Element("noms").TryGetElementValue("nom_launchbox");
            NameHyperspin = rootElement.Element("noms").TryGetElementValue("nom_hyperspin");
            if (rootElement.Element("noms").TryGetElementValue("noms_commun") != null)
            {
                OtherNames.Clear();
                OtherNames.AddRange(rootElement.Element("noms").TryGetElementValue("noms_commun").Split(','));
            }

            // Other Simple
            Developer = rootElement.TryGetElementValue("compagnie");
            Type = rootElement.TryGetElementValue("type");

            // Dates
            DateTime.TryParseExact(rootElement.TryGetElementValue("datedebut"), "yyyy",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateReleased);
            if (dateReleased != DateTime.MinValue) DateReleased = dateReleased;


            DateTime.TryParseExact(rootElement.TryGetElementValue("datefin"), "yyyy",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateDiscontinued);
            if (dateDiscontinued != DateTime.MinValue) DateDiscontinued = dateDiscontinued;


            if (rootElement.TryGetElementValue("romtype") != null)
            { this.RomFileType = Constants.RomFileTypes[rootElement.TryGetElementValue("romtype")]; }

            // RomMediaTypes
            if (rootElement.TryGetElementValue("supporttype") != null)
            {
                string mediaTypes = rootElement.TryGetElementValue("supporttype");

                // Debug.WriteLine(mediaTypes);
                RomMediaTypes.Clear();

                if (mediaTypes == "non-applicable")
                {
                    RomMediaTypes.Add(Constants.RomMediaTypes["non-applicable"]);
                }
                else
                {
                    foreach (string mediaType in rootElement.TryGetElementValue("supporttype").Split('-'))
                    {
                        // Debug.WriteLine(mediaType);
                        if (mediaType != null) RomMediaTypes.Add(Constants.RomMediaTypes[mediaType]);
                    }
                }
            }

            // Now update lists:

            if (rootElement.TryGetElementValue("extensions") != null)
            {
                Extensions.Clear();
                Extensions.AddRange(rootElement.TryGetElementValue("extensions").Split(','));
            }

            MediaList.Clear();
            var medias = rootElement.Descendants("media");
            foreach (var media in medias)
            {
                SystemMedia newMedia = new SystemMedia();
                newMedia.MediaCategory = MediaCategory.System;

                newMedia.Region = media.TryGetAttributeValue("region");
                newMedia.Support = int.Parse( media.TryGetAttributeValue("support", "0"));
                newMedia.CRC = media.TryGetAttributeValue("crc");
                newMedia.MD5 = media.TryGetAttributeValue("md5");
                newMedia.SHA1 = media.TryGetAttributeValue("sha1");
                newMedia.Format = media.TryGetAttributeValue("format");

                if (media.TryGetAttributeValue("type") != null) 
                    newMedia.MediaType = Constants.SystemMediaTypes[media.TryGetAttributeValue("type")];

                newMedia.Uri = media.Value.ToString();

                MediaList.Add(newMedia);
            }
        }



    }
}
