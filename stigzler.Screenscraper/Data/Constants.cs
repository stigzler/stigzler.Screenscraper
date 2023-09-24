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
                    ApiQueryType.GameImages, ApiQueryType.GameVideos, ApiQueryType.GameManuals,
                    ApiQueryType.GameGenreImages, ApiQueryType.GameOrganisationImages, ApiQueryType.SystemImages,
                    ApiQueryType.SystemVideos
                    }
                },
                { ApiQueryGroup.Searches, new List<ApiQueryType>
                    {
                    ApiQueryType.GameRomSearch, ApiQueryType.GameNameSearch
                    }
                },
                { ApiQueryGroup.Uploads, new List<ApiQueryType>
                    {
                    ApiQueryType.AddGameInfo, ApiQueryType.AddGameInfo
                    }
                },
            };



        public static Dictionary<ApiQueryType, string> ApiQueryPaths = new Dictionary<ApiQueryType, string>()
        {
            { ApiQueryType.ClassificaitonList,"classificationListe.php"},
            { ApiQueryType.GameOrganisationImages,"mediaCompagnie.php" },
            { ApiQueryType.GameGenreImages,"mediaGroup.php" },
            { ApiQueryType.GameRomSearch,"jeuInfos.php" },
            { ApiQueryType.GameNameSearch, "jeuRecherche.php" },
            { ApiQueryType.GameInfoList,"infosJeuListe.php" },
            { ApiQueryType.GameManuals,"mediaManuelJeu.php" },
            { ApiQueryType.GameImages,"mediaJeu.php"},
            { ApiQueryType.GameMediaList,"mediasJeuListe.php" },
            { ApiQueryType.AddGameNote,"botNote.php" },
            { ApiQueryType.GameVideos,"mediaVideoJeu .php" },
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
            { ApiQueryType.SystemImages,"mediaSysteme.php" },
            { ApiQueryType.SystemMediaList,"mediasSystemeListe.php" },
            { ApiQueryType.SystemVideos,"mediaVideoSysteme.php" },
            { ApiQueryType.UserInfo,"ssuserInfos.php" },
            { ApiQueryType.UserLevelsList,"userlevelsListe.php" }
        };



        internal static Dictionary<ApiQueryParameter, string> ApiQueryParameters = new Dictionary<ApiQueryParameter, string>()
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

            // Other
            {ApiQueryParameter.RomFilename,"romnom" },



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
