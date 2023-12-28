using stigzler.Screenscraper.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using stigzler.Screenscraper.Data.Entities;
using stigzler.Screenscraper.Data.Models;

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

        public static Dictionary<ApiQueryParameter, string> ApiQueryParameters = new Dictionary<ApiQueryParameter, string>()
        {

            // IDs:
            {ApiQueryParameter.SystemID,"systemeid" },
            {ApiQueryParameter.GenreID, "groupid" },
            {ApiQueryParameter.OrganisationID, "companyid" },

            // Search
            {ApiQueryParameter.SearchGameID, "gameid" },
            {ApiQueryParameter.RomName,"romnom" },
            {ApiQueryParameter.GameName, "recherche" },
            {ApiQueryParameter.CRC, "crc" },
            {ApiQueryParameter.MD5, "md5" },
            {ApiQueryParameter.SHA1, "sha1" },
            {ApiQueryParameter.RomFileType, "romtype" },
            {ApiQueryParameter.RomSize, "romtaille" },
            {ApiQueryParameter.SeriaNumber, "serialnum" },

            // Downloads
            {ApiQueryParameter.DownloadGameID, "jeuid" },
            {ApiQueryParameter.MediaTypeName, "media" },
            {ApiQueryParameter.MediaFormat, "mediaformat" },

            // Debug
            {ApiQueryParameter.DevDebugPassword, "devdebugpassword" },
            {ApiQueryParameter.ForceIP, "forceip" },
            {ApiQueryParameter.ForceLevel, "forcelevel" },
            {ApiQueryParameter.ForceRequestOk, "forcerequestok" },
            {ApiQueryParameter.ForceRequestKo, "forcerequestko" },
            {ApiQueryParameter.ForceRequestMin , "forcerequestmin"},
            {ApiQueryParameter.ForceUpdate, "forceupdate" }
        };

        public static Dictionary<string, RomFileType> RomFileTypes = new Dictionary<string, RomFileType>()
        {
            {"dossier", RomFileType.Folder },
            {"fichier", RomFileType.File },
            {"iso", RomFileType.Iso },
            {"rom", RomFileType.Rom }
        };

        public static Dictionary<string, RomMediaType> RomMediaTypes = new Dictionary<string, RomMediaType>()
        {
            {"map", RomMediaType.Map },
            {"cartouche", RomMediaType.Cartridge },
            {"cd", RomMediaType.CD },
            {"disquette", RomMediaType.FloppyDisk },
            {"hardware", RomMediaType.Hardware },
            {"k7", RomMediaType.Cassette },
            {"non-applicable", RomMediaType.NonApplicable },
            {"pcb", RomMediaType.PCB },
            {"smc", RomMediaType.SMC },
            {"videotape",RomMediaType.Videotape },
            {"web", RomMediaType.Web },
            {"download", RomMediaType.Download},
            {"carte", RomMediaType.Map }
        };

        public static Dictionary<string, MediaCategory> MediaCategories = new Dictionary<string, MediaCategory>()
        {
            {"jeu", MediaCategory.Game },
            {"region", MediaCategory.Region },
            {"developpeur", MediaCategory.Developer },
            {"editeur", MediaCategory.Publisher },
            {"joueurs", MediaCategory.Players },
            {"note", MediaCategory.Score },
            {"genre", MediaCategory.Genre },
            {"systeme", MediaCategory.System }
        };

        public static Dictionary<string, SystemMediaType> SystemMediaTypes = new Dictionary<string, SystemMediaType>()
        {
            {"logo-monochrome", SystemMediaType.LogoMonochrome },
            {"wheel", SystemMediaType.Logo},
            {"logo-monochrome-svg" , SystemMediaType.LogoMonochromeVector },
            {"logo-svg", SystemMediaType.LogoVector },
            {"wheel-hd-vierge", SystemMediaType.LogoHdBlank },
            {"wheel-carbon", SystemMediaType.LogoCarbon },
            {"wheel-carbon-vierge", SystemMediaType.LogoCarbonBlank },
            {"wheel-steel" , SystemMediaType.LogoSteel },
            {"wheel-steel-vierge" , SystemMediaType.LogoSteelBlank },
            {"minicon", SystemMediaType.IconMini },
            {"icon", SystemMediaType.Icon },
            {"photo", SystemMediaType.Photo },
            {"illustration", SystemMediaType.Illustration },
            {"controller", SystemMediaType.Controller },
            {"video", SystemMediaType.Video },
            {"steam-grid", SystemMediaType.SteamGrid },
            {"BoitierConsole3D" , SystemMediaType.SystemBox },
            {"background", SystemMediaType.Background },
            {"screenmarquee" , SystemMediaType.Marquee },
            {"screenmarquee-vierge", SystemMediaType.MarqueeBlank },
            {"bezel-16-9" , SystemMediaType.Bezel16_9 },
            {"bezel-16-9v" , SystemMediaType.Bezel16_9Vertical },
            {"bezel-16-9-v" , SystemMediaType.Bezel16_9Vertical },
            {"bezel-4-3" , SystemMediaType.Bezel4_3 },
            {"box-back-vierge" , SystemMediaType.GameBoxBack },
            {"box-tranche-vierge", SystemMediaType.GameBoxSpine },
            {"box-vierge", SystemMediaType.GameBox },
            {"box3D", SystemMediaType.GameBox3d },
            {"box-texture-gabarit", SystemMediaType.GameBoxTemplate },
            {"support2D", SystemMediaType.GameMedia2d },
            {"support-texture-gabarit", SystemMediaType.GameMediaTemplate },
            {"controls", SystemMediaType.Controls }
        };

        public static Dictionary<string, GameMediaType> GameMediaTypes = new Dictionary<string, GameMediaType>()
        {
            {"bezel-16-9-cocktail", GameMediaType.Bezel16_9Cocktail },
            {"bezel-16-9", GameMediaType.Bezel16_9 },
            {"bezel-16-9-v", GameMediaType.Bezel16_9Vertical },
            {"bezel-4-3-cocktail", GameMediaType.Bezel4_3Cocktail },
            {"bezel-4-3", GameMediaType.Bezel4_3 },
            {"bezel-4-3-v", GameMediaType.Bezel4_3Vertical },
            {"box-3D", GameMediaType.Box3d },
            {"box-texture", GameMediaType.BoxSleeve },
            {"box-2D-back", GameMediaType.Box2dBack },
            {"box-2D", GameMediaType.Box2dFront },
            {"box-2D-side", GameMediaType.Box2dSpine },
            {"wheel-hd", GameMediaType.LogoHD },
            {"wheel", GameMediaType.Logo },
            {"wheel-carbon", GameMediaType.LogoCarbon },
            {"wheel-steel", GameMediaType.LogoSteel },
            {"fanart", GameMediaType.Fanart },
            {"flyer", GameMediaType.Flyer },
            {"manuel", GameMediaType.Manual  },
            {"maps", GameMediaType.Map },
            {"marquee", GameMediaType.Marquee },
            {"screenmarqueesmall", GameMediaType.MarqueeScreenSmall },
            {"screenmarquee", GameMediaType.MarqueeScreen },
            {"ss", GameMediaType.ScreenshotGameplay },
            {"sstitle", GameMediaType.ScreenshotTitle },
            {"steamgrid", GameMediaType.SteamGrid },
            {"themehs", GameMediaType.HyperspinTheme },
            {"video", GameMediaType.Video },
            {"video-normalized", GameMediaType.VideoStandardised },
            {"ssdmd", GameMediaType.ScreenshotDmd },
            {"ssfronton16-9", GameMediaType.ScreenshotFrontend16_9 },
            {"ssfronton1-1", GameMediaType.ScreenshotFrontend1_1 },
            {"ssfronton4-3", GameMediaType.ScreenshotFrontend4_3 },
            {"sstable", GameMediaType.ScreenshotTable },
            {"sstopper", GameMediaType.ScreenshotTopper },
            {"videodmd", GameMediaType.VideoDmd },
            {"videofronton4-3", GameMediaType.VideoFrontend4_3 },
            {"videofronton16-9", GameMediaType.VideoFrontend16_9 },
            {"videotable4k", GameMediaType.VideoTable4k },
            {"videotable", GameMediaType.VideoTable },
            {"videotopper", GameMediaType.VideoTopper },
            {"wheel-tarcisios", GameMediaType.Bezel16_9Cocktail },
            {"mixrbv1", GameMediaType.RecalboxMix1 },
            {"mixrbv2", GameMediaType.RecalboxMix2 },
            {"box-scan", GameMediaType.ScanBox },
            {"support-scan", GameMediaType.ScanLabel },
            {"support-2D", GameMediaType.Media2d },
            {"support-texture", GameMediaType.MediaLabel },
            {"pictoliste", GameMediaType.Icon },
            {"pictomonochrome", GameMediaType.ImageMonochrome },
            {"pictocouleur", GameMediaType.ImageColor }
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

        internal static ApiCredentials DummyApiCredentials = new ApiCredentials()
        {
            DeveloperID = "xxx",
            DeveloperPassword = "yyy",
            DeveloperSoftware = "zzz",
            UserID = "test",
            UserPassword = "test"
        };

        internal static ApiServerParameters StandardApiServerParameters = new ApiServerParameters()
        {
            HostAddress = "https://www.screenscraper.fr",
            ApiPath = "api2",
            HttpTimeout = 5000
        };

        /// <summary>
        /// Incomplete at present.
        /// </summary>
        internal static Dictionary<ApiQueryType, string> QueryTypeElementName = new Dictionary<ApiQueryType, string>
        {
            {ApiQueryType.GenreList, "genre" },
            {ApiQueryType.LanguageList, "langue" },
            {ApiQueryType.RegionList, "region"},
            {ApiQueryType.SystemList, "systeme" }
        };




    }
}
