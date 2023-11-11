using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stigzler.Screenscraper.Data.Entities
{
    public class Genre
    {
        public int ID { get; set; }
        public int ParentGenreID { get; set; }
        public string NameEnglish { get; set; }
        public string NameFench { get; set; }   
        public string NameGerman { get; set; }
        public string NameSpanish { get; set; }
        public string NameItalian { get; set; }
        public string NamePortugese { get; set; }
        public string ImageUri { get; set; }

    }
}
