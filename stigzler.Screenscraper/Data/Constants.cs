using stigzler.Screenscraper.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using stigzler.Screenscraper.Data.Entities;

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
            //{ApiQueryParameter.DeveloperID,"devid"},
            //{ApiQueryParameter.DeveloperPassword,"devpassword"},
            //{ApiQueryParameter.DeveloperSoftwareName,"softname"},
            //{ApiQueryParameter.Username,"ssid" },
            //{ApiQueryParameter.Password,"sspassword"},

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

        public static Dictionary<string, MediaType> MediaTypes = new Dictionary<string, MediaType>()
        {
            {"logo-monochrome", MediaType.LogoMonochrome },
            {"wheel", MediaType.Logo},
            {"logo-monochrome-svg" , MediaType.LogoMonochromeVector },
            {"logo-svg", MediaType.LogoVector },
            {"wheel-hd-vierge", MediaType.LogoHdBlank },
            {"wheel-carbon", MediaType.LogoCarbon },
            {"wheel-carbon-vierge", MediaType.LogoCarbonBlank },
            {"wheel-steel" , MediaType.LogoSteel },
            {"wheel-steel-vierge" , MediaType.LogoSteelBlank },
            {"minicon", MediaType.IconMini },
            {"icon", MediaType.Icon },
            {"photo", MediaType.Photo },
            {"illustration", MediaType.Illustration },
            {"controller", MediaType.Controller },
            {"video", MediaType.Video },
            {"steam-grid", MediaType.SteamGrid },
            {"BoitierConsole3D" , MediaType.SystemBox },
            {"background", MediaType.Background },
            {"screenmarquee" , MediaType.Marquee },
            {"screenmarquee-vierge", MediaType.MarqueeBlank },
            {"bezel-16-9" , MediaType.Bezel16_9 },
            {"bezel-16-9v" , MediaType.Bezel16_9Vertical },
            {"bezel-4-3" , MediaType.Bezel4_3 },
            {"box-back-vierge" , MediaType.SystemGameBoxBack },
            {"box-tranche-vierge", MediaType.SystemGameBoxSpine },
            {"box-vierge", MediaType.SystemGameBox },
            {"box3D", MediaType.SystemGameBox3d },
            {"box-texture-gabarit", MediaType.SystemGameBoxTemplate },
            {"support2D", MediaType.SystemGameMedia2d },
            {"support-texture-gabarit", MediaType.SystemGameMediaTemplate },
            {"controls", MediaType.Controls }
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









    }
}
