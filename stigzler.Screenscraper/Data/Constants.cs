using stigzler.Screenscraper.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stigzler.Screenscraper.Data
{
    internal static class Constants
    {
        internal static int MaxApiThreads = 7;

       

        internal static Dictionary<ApiQueryType, string> ApiQueryPaths = new Dictionary<ApiQueryType, string>()
        {
            { ApiQueryType.ClassificaitonList,"classificationList.php"},
            { ApiQueryType.GameCompanyMedia,"mediaCompagnie.php" },
            { ApiQueryType.GameGroupMedia,"mediaGroup.php" },
            { ApiQueryType.GameInfo,"jeuInfos.php" },
            { ApiQueryType.GameInfoList,"jeuRecherche.php" },
            { ApiQueryType.GameList ,"infosJeuListe.php" },
            { ApiQueryType.GameManuals,"mediaManuelJeu.php" },
            { ApiQueryType.GameMedia,"mediaJeu.php"},
            { ApiQueryType.GameMediaList,"mediasJeuListe.php" },
            { ApiQueryType.GameNote,"botNote.php" },
            { ApiQueryType.GameVideos,"mediaVideoJeu .php" },
            { ApiQueryType.GerneList,"genresList.php" },
            { ApiQueryType.LanguageList,"languagesList.php" },
            { ApiQueryType.MediaTypesList,"mediasJeuListe.php" },
            { ApiQueryType.NumberOfPlayersList,"nbJoueursListe.php" },
            { ApiQueryType.Proposition,"botProposition.php" },
            { ApiQueryType.RegionList,"regionsList.php" },
            { ApiQueryType.RomInfoList,"infosRomListe.php" },
            { ApiQueryType.RomTypesList,"romTypesListe.php" },
            { ApiQueryType.ServerInfo, "ssinfraInfos.php"},
            { ApiQueryType.SystemList,"systemesListe.php" },
            { ApiQueryType.SystemMedia,"mediaSysteme.php" },
            { ApiQueryType.SystemMediaList,"mediasSystemeListe.php" },
            { ApiQueryType.SystemVideos,"mediaVideoSysteme.php" },
            { ApiQueryType.UserInfo,"ssuserInfos.php" },
            { ApiQueryType.UserLevelsList,"userlevelsListe.php" }
        };

        internal static Dictionary<ApiQueryParameter, string> ApiQueryParameters = new Dictionary<ApiQueryParameter, string>()
        {
            {ApiQueryParameter.DeveloperID,"devid"},
            {ApiQueryParameter.DeveloperPassword,"devpassword"},
            {ApiQueryParameter.DeveloperSoftwareName,"softname"},
            {ApiQueryParameter.Username,"ssid" },
            {ApiQueryParameter.Password,"sspassword"},
            {ApiQueryParameter.SystemID,"systemeid" },
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
