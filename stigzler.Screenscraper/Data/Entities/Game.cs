using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stigzler.Screenscraper.Data.Entities
{
    [Serializable]
    public class Game
    {
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
        public Dictionary<string,string> Names { get; set; }

        /// <summary>
        /// GameID of any Clones
        /// </summary>
        public int CloneOf { get; set; }

        /// <summary>
        /// The System for the Game
        /// Key = ID, Value = Name
        /// </summary>
        public KeyValuePair<int,string> System { get; set; }

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
        public Dictionary<string,string> Synopses { get; set; }

        /// <summary>
        /// Release dates in different regions
        /// Key = region, Value = Synopsis
        /// </summary>
        public Dictionary<string, DateTime> ReleaseDates { get; set; }

        /// <summary>
        /// Game Genres
        /// Key = region, Value = Synopsis
        /// </summary>
        public Dictionary<int, string> Genres { get; set; }


    }
}
