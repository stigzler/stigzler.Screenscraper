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

    public enum ApiQueryType
    {
        // Metadata
        ServerInfo,
        UserInfo,
        UserLevelsList,
        NumberOfPlayersList,
        MediaTypesList,
        RomTypesList,
        GerneList,
        RegionList,
        LanguageList,
        ClassificaitonList,
        SystemMediaList,
        GameMediaList,
        GameInfoList,       // This returns the different types of info. Eg. Family, Mode, Number, Resolution, Themes
        RomInfoList,
        SystemList,
        GameList,           //Search for a game with its name (returns a table of games (limited to 30 games) classified by probability)
        GameInfo,
        GameNote,
        Proposition,

        // Media
        GameMedia,
        GameVideos,
        GameManuals,
        GameGroupMedia,
        GameCompanyMedia,
        SystemMedia,
        SystemVideos
    }

    public enum ApiQueryParameter
    {
        None,
        DeveloperID,
        DeveloperPassword,
        DeveloperSoftwareName,
        Username,
        Password,
        SystemID,
        RomFilename


    }

}
