using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stigzler.Screenscraper.Enums
{
    public enum ApiQueryParameter
    {
        None,

        // IDs
        SystemID,
        GenreID,
        OrganisationID,

        // Search
        SearchGameID,
        RomName,
        GameName,
        RomFileType,
        RomSize,
        SeriaNumber,

        // Download
        DownloadGameID,
        CRC,
        MD5,
        SHA1,
        MediaTypeName,
        MediaFormat,

        // Debug
        DevDebugPassword,
        ForceIP,
        ForceLevel,
        ForceRequestOk,
        ForceRequestKo,
        ForceRequestMin,
        ForceUpdate


    }

}
