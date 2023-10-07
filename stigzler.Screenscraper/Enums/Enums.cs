using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stigzler.Screenscraper.Enums
{
    public enum MetadataOutput
    {
        xml = 0,
        json = 1
    }

    public enum ApiQueryGroup
    {
        InfoAndLists,
        Downloads,
        Searches,
        Uploads
    }

    public enum ApiQueryType
    {
        ServerInfo,
        UserInfo,
        UserLevelsList,
        NumberOfPlayersList,
        RomMediaTypesList,
        RomFileTypesList,
        GenreList,
        RegionList,
        LanguageList,
        ClassificaitonList,
        SystemMediaList,
        GameMediaList,
        GameInfoList,       // This returns the different types of info. Eg. Family, Mode, Number, Resolution, Themes
        RomInfoList,
        SystemList,
        GameNameSearch,
        GameRomSearch,
        AddGameNote,
        AddGameInfo,




        GameImageDownload,
        /// <summary>
        /// Download 
        /// Requires: SystemID, GameID, MediaTypeName (despite its redundancy)
        /// </summary>
        GameVideoDownload,
        GameManualDownload,
        GameGenreImageDownload,
        GameOrganisationImageDownload,
        SystemImageDownload,
        SystemVideoDownload
    }

 

    public enum ApiQueryParameter
    {
        None,

        // IDs
        SystemID,
        GameID,
        GenreID,
        OrganisationID,
        RomFilename,

        // Download
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
