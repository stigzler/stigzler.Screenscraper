using stigzler.Screenscraper.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stigzler.Screenscraper.Data
{
    public static class Constants
    {
        internal static int MaxApiThreads = 7;

        public static Dictionary<ApiQueryGroup, List<ApiQueryType>> ApiQueryGroups =
            new Dictionary<ApiQueryGroup, List<ApiQueryType>>()
            {
                { ApiQueryGroup.InfoAndLists, new List<ApiQueryType>
                    {
                     ApiQueryType.ServerInfo, ApiQueryType.UserInfo, ApiQueryType.UserLevelsList,
                     ApiQueryType.RomMediaTypesList, ApiQueryType.RomFileTypesList, ApiQueryType.GenreList,
                     ApiQueryType.RegionList, ApiQueryType.LanguageList, ApiQueryType.ClassificaitonList,
                     ApiQueryType.SystemMediaList, ApiQueryType.GameMediaList, ApiQueryType.GameInfoList,
                     ApiQueryType.RomInfoList, ApiQueryType.SystemList, ApiQueryType.NumberOfPlayersList
                    }
                },
                { ApiQueryGroup.Downloads, new List<ApiQueryType>
                    {
                    ApiQueryType.GameImageDownload, ApiQueryType.GameVideoDownload, ApiQueryType.GameManualDownload,
                    ApiQueryType.GameGenreImageDownload, ApiQueryType.GameOrganisationImageDownload, ApiQueryType.SystemImageDownload,
                    ApiQueryType.SystemVideoDownload
                    }
                },
                { ApiQueryGroup.Searches, new List<ApiQueryType>
                    {
                    ApiQueryType.GameRomSearch, ApiQueryType.GameNameSearch
                    }
                },
                { ApiQueryGroup.Uploads, new List<ApiQueryType>
                    {
                    ApiQueryType.AddGameNote, ApiQueryType.AddGameInfo
                    }
                },
            };



        internal static Dictionary<ApiQueryType, string> ApiQueryPaths = new Dictionary<ApiQueryType, string>()
        {
            { ApiQueryType.ClassificaitonList,"classificationListe.php"},
            { ApiQueryType.GameOrganisationImageDownload,"mediaCompagnie.php" },
            { ApiQueryType.GameGenreImageDownload,"mediaGroup.php" },
            { ApiQueryType.GameRomSearch,"jeuInfos.php" },
            { ApiQueryType.GameNameSearch, "jeuRecherche.php" },
            { ApiQueryType.GameInfoList,"infosJeuListe.php" },
            { ApiQueryType.GameManualDownload,"mediaManuelJeu.php" },
            { ApiQueryType.GameImageDownload,"mediaJeu.php"},
            { ApiQueryType.GameMediaList,"mediasJeuListe.php" },
            { ApiQueryType.AddGameNote,"botNote.php" },
            { ApiQueryType.GameVideoDownload,"mediaVideoJeu.php" },
            { ApiQueryType.GenreList,"genresListe.php" },
            { ApiQueryType.LanguageList,"languesListe.php" },
            { ApiQueryType.NumberOfPlayersList,"nbJoueursListe.php" },
            { ApiQueryType.AddGameInfo,"botProposition.php" },
            { ApiQueryType.RegionList,"regionsListe.php" },
            { ApiQueryType.RomInfoList,"infosRomListe.php" },
            { ApiQueryType.RomFileTypesList,"romTypesListe.php" },
            { ApiQueryType.RomMediaTypesList,"supportTypesListe.php" },
            { ApiQueryType.ServerInfo, "ssinfraInfos.php"},
            { ApiQueryType.SystemList,"systemesListe.php" },
            { ApiQueryType.SystemImageDownload,"mediaSysteme.php" },
            { ApiQueryType.SystemMediaList,"mediasSystemeListe.php" },
            { ApiQueryType.SystemVideoDownload,"mediaVideoSysteme.php" },
            { ApiQueryType.UserInfo,"ssuserInfos.php" },
            { ApiQueryType.UserLevelsList,"userlevelsListe.php" }
        };



        public static Dictionary<ApiQueryParameter, string> ApiQueryParameters = new Dictionary<ApiQueryParameter, string>()
        {
            //{ApiQueryParameter.DeveloperID,"devid"},
            //{ApiQueryParameter.DeveloperPassword,"devpassword"},
            //{ApiQueryParameter.DeveloperSoftwareName,"softname"},
            //{ApiQueryParameter.Username,"ssid" },
            //{ApiQueryParameter.Password,"sspassword"},

            // IDs:
            {ApiQueryParameter.SystemID,"systemeid" },
            {ApiQueryParameter.GameID, "jeuid" },
            {ApiQueryParameter.GenreID, "groupid" },
            {ApiQueryParameter.OrganisationID, "companyid" },

            // Downloads
            {ApiQueryParameter.RomFilename,"romnom" },
            {ApiQueryParameter.MediaTypeName, "media" },
            {ApiQueryParameter.MediaFormat, "mediaformat" },
            {ApiQueryParameter.CRC, "crc" },
            {ApiQueryParameter.MD5, "md5" },
            {ApiQueryParameter.SHA1, "sha1" },

            // Debug
            {ApiQueryParameter.DevDebugPassword, "devdebugpassword" },
            {ApiQueryParameter.ForceIP, "forceip" },
            {ApiQueryParameter.ForceLevel, "forcelevel" },
            {ApiQueryParameter.ForceRequestOk, "forcerequestok" },
            {ApiQueryParameter.ForceRequestKo, "forcerequestko" },
            {ApiQueryParameter.ForceRequestMin , "forcerequestmin"},
            {ApiQueryParameter.ForceUpdate, "forceupdate" }
        };








    }
}
