using stigzler.Screenscraper.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace stigzler.Screenscraper.Data.Entities
{
    public class Genre
    {
        public int ID { get; set; }
        public int ParentID { get; set; }
        public string NameEnglish { get; set; }
        public string NameFench { get; set; }
        public string NameGerman { get; set; }
        public string NameSpanish { get; set; }
        public string NameItalian { get; set; }
        public string NamePortugese { get; set; }
        public string Media { get; set; }

        public Genre()
        {

        }
        public Genre(XElement rootElement)
        {
            UpdateFromXElement(rootElement);
        }

        public void UpdateFromXElement(XElement rootElement)
        {
            ID = Int32.Parse(rootElement.TryGetElementValue("id"));
            ParentID = Int32.Parse(rootElement.TryGetElementValue("parent"));
            NameEnglish = rootElement.TryGetElementValue("nom_en");
            NameFench = rootElement.TryGetElementValue("nom_fr");
            NameGerman = rootElement.TryGetElementValue("nom_de");
            NameItalian = rootElement.TryGetElementValue("nom_it");
            NamePortugese = rootElement.TryGetElementValue("nom_pt");
            NameSpanish = rootElement.TryGetElementValue("nom_es");
            XElement media = rootElement.Descendants("media_pictomonochrome").First();

            Media = HttpUtility.HtmlDecode(media.Value);

        }


    }
}
