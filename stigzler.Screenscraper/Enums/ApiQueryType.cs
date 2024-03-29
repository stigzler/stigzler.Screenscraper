﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stigzler.Screenscraper.Enums
{
    public enum ApiQueryType
    {
        None,
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
        /// <summary>
        /// This returns the different types of game information.
        /// <example>
        /// Eg. Family, Mode, Number, Resolution, Themes
        /// </example>
        /// </summary>
        GameInfoList,
        RomInfoList,
        SystemList,
        GameNameSearch,
        GameRomSearch,
        AddGameNote,
        AddGameInfo,
        GameImageDownload,
        /// <summary>
        /// Downloads video for specified Game. 
        /// Requires <c cref="ApiQueryParameter">ApiQueryParameters:</c> SystemID, GameID, MediaTypeName
        /// </summary>
        GameVideoDownload,
        GameManualDownload,
        GameGenreImageDownload,
        GameOrganisationImageDownload,
        SystemImageDownload,
        SystemVideoDownload
    }

}
