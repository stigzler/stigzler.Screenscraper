using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stigzler.Screenscraper.Data.Models
{
    /// <summary>
    /// Used interchangeably with ApiQueryType.GameNameSearch and ApiQueryType.GameRomSearch. 
    /// Not all properties need to be set. 
    /// </summary>
    public class ApiSearchParameters
    {

        /// <summary>
        /// SystemID of the related system
        /// </summary>
        public int SystemID { get; set; } = -1;

        /// <summary>
        /// The ID of the Game being searched for. 
        /// </summary>
        public int GameID { get; set; } = -1;

        /// <summary>
        /// The Game Name to search for. Used with ApiQueryType.GameNameSearch.
        /// </summary>
        public string GameName { get; set; } = null;

        /// <summary>
        /// The game Rom to search for. Used with ApiQueryType.GameRomSearch.
        /// </summary>
        public string RomName { get; set; } = null;


        /// <summary>
        /// CRC of the game rom
        /// </summary>
        public string CRC { get; set; } = null;
        /// <summary>
        /// MD5 of the game rom
        /// </summary>
        public string MD5 { get; set; } = null;
        /// <summary>
        /// SHA1 of the game rom
        /// </summary>
        public string SHA1 { get; set; } = null;

        /// <summary>
        /// The type of rom to search for. Types are those returned by ApiQueryType.RomFileTypesList
        /// </summary>
        public string RomFileType { get; set; } = null;

        /// <summary>
        /// Size of the rom in Bytes
        /// </summary>
        public int RomSize { get; set; } = -1;

        /// <summary>
        /// Not clear on this - Screenscraper API page states: 
        /// "Force search for the game with the number serial of the rom (iso) associated"
        /// </summary>
        public int SerialNumber { get; set; } = -1;


    }
}
