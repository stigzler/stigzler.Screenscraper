using stigzler.Screenscraper.Extensions;
using System;
using System.Collections.Generic;
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
        public int ID { get; set; }

        /// <summary>
        /// If Game details retrieved via RomName, this is the Rom match that game match made from
        /// </summary>
        public int MatchedRomID { get; set; }

        /// <summary>
        /// If data is a game or not
        /// </summary>
        public bool NotGame { get; set; }

        /// <summary>
        /// Region and GameName
        /// Represents the different game names for different regions
        /// </summary>
        public Dictionary<string, string> Names { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// GameID of any Clones
        /// </summary>
        public int CloneOf { get; set; }

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
        public int Score { get; set; }

        /// <summary>
        /// Whether in the Screenscraper top picks selection
        /// </summary>
        public bool ScreenscraperPick { get; set; }

        /// <summary>
        /// For arcade games
        /// </summary>
        public int Rotation { get; set; }

        /// <summary>
        /// Game Synopses in different languages
        /// Key = language, Value = Synopsis
        /// </summary>
        public Dictionary<string, string> Synopses { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// Release dates in different regions
        /// Key = region, Value = Synopsis
        /// </summary>
        public Dictionary<string, DateTime> ReleaseDates { get; set; } = new Dictionary<string, DateTime>();

        /// <summary>
        /// Game Genres
        /// Key = region, Value = Synopsis
        /// </summary>
        public List<KeyValuePair<int, string>> Genres { get; set; } = new List<KeyValuePair<int, string>>();

        /// <summary>
        /// You must feed in the "jeu" Element for the game
        /// </summary>
        /// <param name="rootElement"></param>
        public void UpdateFromXElement(XElement rootElement)
        {
            XElement jeuElement = rootElement.AncestorsAndSelf().First();

            ID = Int32.Parse(jeuElement.Attribute("id").Value);
            MatchedRomID = Int32.Parse(jeuElement.Attribute("romid").Value);
            NotGame = bool.Parse(jeuElement.Attribute("notgame").Value);

            // Names
            Names.Clear();
            foreach (XElement name in jeuElement.Descendants("nom"))
            {
                Names.Add(name.Attribute("region").Value, name.Value);
            }

            CloneOf = Int32.Parse(jeuElement.Element("cloneof").Value);

            System = new KeyValuePair<int, string>(
                Int32.Parse(jeuElement.Element("systeme").Attribute("id").Value),
                jeuElement.Descendants("systeme").First().Value
                );

            Publisher = new KeyValuePair<int, string>(
                Int32.Parse(jeuElement.Element("editeur").Attribute("id").Value),
                jeuElement.Element("editeur").Value
                );

            Developer = new KeyValuePair<int, string>(
                Int32.Parse(jeuElement.Element("developpeur").Attribute("id").Value),
                jeuElement.Element("developpeur").Value
                );

            Players = jeuElement.Element("jouers").Value;

            Score = Int32.Parse(jeuElement.Element("note").Value);

            ScreenscraperPick = bool.Parse(jeuElement.Attribute("topstaff").Value);

            Rotation = Int32.Parse(jeuElement.Element("rotation").Value);

            Synopses.Clear();
            foreach (XElement synopsis in jeuElement.Descendants("synopsis"))
            {
                Synopses.Add(synopsis.Attribute("langue").Value, synopsis.Value);
            }

            ReleaseDates.Clear();
            foreach (XElement releaseDate in jeuElement.Descendants("date"))
            {
                DateTime.TryParse(releaseDate.Value, out DateTime dateReleased);
                if (dateReleased != DateTime.MinValue)
                {
                    ReleaseDates.Add(releaseDate.Attribute("region").Value, dateReleased);
                }
            }

            Genres.Clear();
            var genreElements = jeuElement.Descendants("genre");
            foreach (var uniqueGenreElement in genreElements.Where(x=> x.Attribute("id"))


            foreach (XElement genre in jeuElement.Descendants("genre"))
            {
                Genres.Add(new KeyValuePair<int, string> (genre.Attribute("region").Value, genre.Value));
            }


        }
    }

}
