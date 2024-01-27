using stigzler.Screenscraper.Enums;
using stigzler.Screenscraper.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace stigzler.Screenscraper.Data.Entities
{
    [Serializable]
    public class Game
    {
        public Game()
        {

        }

        public Game(XElement rootElement)
        {
            UpdateFromXElement(rootElement);
        }

        /// <summary>
        /// Game ID
        /// </summary>
        public Int32 ID { get; set; } = -1;

        /// <summary>
        /// If Game details retrieved via RomName, this is the Rom match that game match made from
        /// </summary>
        public Int32 MatchedRomID { get; set; } = -1;

        /// <summary>
        /// If data is a game or not
        /// </summary>
        public bool NotGame { get; set; } = false;

        /// <summary>
        /// Region and GameName
        /// Represents the different game names for different regions
        /// </summary>
        public Dictionary<string, string> Names { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// GameID of any Clones
        /// </summary>
        public int CloneOf { get; set; } = -1;

        /// <summary>
        /// The System for the Game
        /// Key = ID, Value = Name
        /// </summary>
        public KeyValuePair<int, string> System { get; set; }

        /// <summary>
        /// The Publisher of the Game
        /// Key = ID, Value = Name
        /// </summary>
        public KeyValuePair<int, string> Publisher { get; set; }

        /// <summary>
        /// The Developer of the Game
        /// Key = ID, Value = Name
        /// </summary>
        public KeyValuePair<int, string> Developer { get; set; }

        /// <summary>
        /// Number of players. String due to being mixed format (e.g. "1-4")
        /// </summary>
        public string Players { get; set; }

        /// <summary>
        /// Score out of 20
        /// </summary>
        public int Score { get; set; } = -1;

        /// <summary>
        /// Whether in the Screenscraper top picks selection
        /// </summary>
        public bool ScreenscraperPick { get; set; }

        /// <summary>
        /// For arcade games
        /// </summary>
        public int Rotation { get; set; } = -1;

        /// <summary>
        /// Game Synopses in different languages
        /// Key = language, Value = Synopsis
        /// </summary>
        public Dictionary<string, string> Synopses { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// Release dates in different regions
        /// Key = region, Value = Release Dates
        /// </summary>
        public Dictionary<string, DateTime> ReleaseDates { get; set; } = new Dictionary<string, DateTime>();

        /// <summary>
        /// Game Genres
        /// Key = region, Value = Genre Data Object
        /// </summary>
        public List<Genre> Genres { get; set; } = new List<Genre>();

        /// <summary>
        /// List of GameMedia associated with this game
        /// </summary>
        public List<GameMedia> MediaList { get; set; } = new List<GameMedia>();


        /// <summary>
        /// You must feed in the "jeu" Element for the game
        /// </summary>
        /// <param name="rootElement"></param>
        public void UpdateFromXElement(XElement rootElement)
        {
            XElement jeuElement = rootElement.AncestorsAndSelf().First();

            if (jeuElement == null) return;

            ID = Int32.Parse(jeuElement.TryGetAttributeValue("id"));
            if (jeuElement.TryGetAttributeValue("romid") != null && jeuElement.TryGetAttributeValue("romid") != "")
                MatchedRomID = Int32.Parse(jeuElement.TryGetAttributeValue("romid"));

            NotGame = bool.Parse(jeuElement.Attribute("notgame").Value);

            // Names
            Names.Clear();
            foreach (XElement name in jeuElement.Descendants("nom"))
            {
                Names.Add(name.TryGetAttributeValue("region"), name.Value);
            }

            CloneOf = Int32.Parse(jeuElement.TryGetElementValue("cloneof", "-1"));

            System = new KeyValuePair<int, string>(
                Int32.Parse(jeuElement.Element("systeme").TryGetAttributeValue("id")),
                jeuElement.Descendants("systeme").First().Value
                );

            var publisher = jeuElement.TryGetElementValue("editeur");
            if (publisher != null)
            {
                Publisher = new KeyValuePair<int, string>(
                    Int32.Parse(jeuElement.Element("editeur").TryGetAttributeValue("id")),
                    jeuElement.Element("editeur").Value
                    );
            }

            var developer = jeuElement.TryGetElementValue("developpeur");
            if (developer != null)
            {
                Developer = new KeyValuePair<int, string>(
                Int32.Parse(jeuElement.Element("developpeur").TryGetAttributeValue("id")),
                jeuElement.Element("developpeur").Value
                );
            }


            Players = jeuElement.TryGetElementValue("joueurs");

            Score = Int32.Parse(jeuElement.TryGetElementValue("note", "-1"));

            ScreenscraperPick = Convert.ToBoolean(Convert.ToInt16(jeuElement.TryGetElementValue("topstaff")));

            Rotation = Int32.Parse(jeuElement.TryGetElementValue("rotation"));

            Synopses.Clear();
            foreach (XElement synopsis in jeuElement.Descendants("synopsis"))
            {
                if (synopsis.TryGetAttributeValue("langue") != null) Synopses.Add(synopsis.TryGetAttributeValue("langue"), synopsis.Value);
            }

            ReleaseDates.Clear();
            foreach (XElement releaseDate in jeuElement.Descendants("date"))
            {
                DateTime.TryParse(releaseDate.Value, out DateTime dateReleased);
                if (dateReleased != DateTime.MinValue && !ReleaseDates.ContainsKey(releaseDate.TryGetAttributeValue("region")))
                {
                    ReleaseDates.Add(releaseDate.TryGetAttributeValue("region"), dateReleased);
                }
            }

            Genres.Clear();
            var groupedGenres = jeuElement.Descendants("genre").GroupBy(x => x.Attribute("id").Value);

            foreach (IGrouping<string, XElement> genreGroupXelements in groupedGenres)
            {
                Genre genre = new Genre();
                genre.ID = Convert.ToInt32(genreGroupXelements.First().TryGetAttributeValue("id"));
                genre.ParentID = Convert.ToInt32(genreGroupXelements.First().TryGetAttributeValue("parentid"));

                foreach (XElement xElement in genreGroupXelements)
                {
                    switch (xElement.TryGetAttributeValue("langue"))
                    {
                        case "en":
                            genre.NameEnglish = xElement.Value; break;
                        case "fr":
                            genre.NameFench = xElement.Value; break;
                        case "de":
                            genre.NameGerman = xElement.Value; break;
                        case "es":
                            genre.NameSpanish = xElement.Value; break;
                        case "it":
                            genre.NameItalian = xElement.Value; break;
                        case "pt":
                            genre.NamePortugese = xElement.Value; break;
                        default:
                            break;
                    }
                }
                Genres.Add(genre);
            }

            MediaList.Clear();
            var medias = jeuElement.Descendants("media");
            foreach (var media in medias)
            {
                GameMedia newMedia = new GameMedia();

                newMedia.Region = media.TryGetAttributeValue("region");
                newMedia.CRC = media.TryGetAttributeValue("crc");
                newMedia.MD5 = media.TryGetAttributeValue("md5");
                newMedia.SHA1 = media.TryGetAttributeValue("sha1");
                newMedia.Size = Convert.ToInt32(media.TryGetAttributeValue("size"));
                newMedia.Format = media.TryGetAttributeValue("format");

                if (media.TryGetAttributeValue("type") != null)
                    newMedia.MediaType = Constants.GameMediaTypes[media.TryGetAttributeValue("type")];

                switch (media.TryGetAttributeValue("parent"))
                {
                    case "region":
                        newMedia.MediaCategory = MediaCategory.Region; break;
                    case "editeur":
                        newMedia.MediaCategory = MediaCategory.Publisher; break;
                    case "developpeur":
                        newMedia.MediaCategory = MediaCategory.Developer; break;
                    case "joueurs":
                        newMedia.MediaCategory = MediaCategory.Players; break;
                    case "note":
                        newMedia.MediaCategory = MediaCategory.Score; break;
                    case "genre":
                        newMedia.MediaCategory = MediaCategory.Genre;
                        newMedia.AssociatedId = Convert.ToInt32(media.TryGetAttributeValue("id"));
                        break;
                    default:
                        newMedia.MediaCategory = MediaCategory.Game; break;
                }

                newMedia.Uri = media.Value.ToString();
                MediaList.Add(newMedia);
            }

        }
    }

}
