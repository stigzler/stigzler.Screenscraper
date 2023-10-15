<a name='assembly'></a>
# stigzler.Screenscraper

## Contents

- [APIDownloadParameters](#T-stigzler-Screenscraper-Data-Models-APIDownloadParameters 'stigzler.Screenscraper.Data.Models.APIDownloadParameters')
  - [CRC](#P-stigzler-Screenscraper-Data-Models-APIDownloadParameters-CRC 'stigzler.Screenscraper.Data.Models.APIDownloadParameters.CRC')
  - [MD5](#P-stigzler-Screenscraper-Data-Models-APIDownloadParameters-MD5 'stigzler.Screenscraper.Data.Models.APIDownloadParameters.MD5')
  - [MediaFormat](#P-stigzler-Screenscraper-Data-Models-APIDownloadParameters-MediaFormat 'stigzler.Screenscraper.Data.Models.APIDownloadParameters.MediaFormat')
  - [MediaTypeName](#P-stigzler-Screenscraper-Data-Models-APIDownloadParameters-MediaTypeName 'stigzler.Screenscraper.Data.Models.APIDownloadParameters.MediaTypeName')
  - [ObjectID](#P-stigzler-Screenscraper-Data-Models-APIDownloadParameters-ObjectID 'stigzler.Screenscraper.Data.Models.APIDownloadParameters.ObjectID')
  - [SHA1](#P-stigzler-Screenscraper-Data-Models-APIDownloadParameters-SHA1 'stigzler.Screenscraper.Data.Models.APIDownloadParameters.SHA1')
  - [SystemID](#P-stigzler-Screenscraper-Data-Models-APIDownloadParameters-SystemID 'stigzler.Screenscraper.Data.Models.APIDownloadParameters.SystemID')
- [ApiCredentials](#T-stigzler-Screenscraper-Data-Models-ApiCredentials 'stigzler.Screenscraper.Data.Models.ApiCredentials')
  - [DeveloperID](#P-stigzler-Screenscraper-Data-Models-ApiCredentials-DeveloperID 'stigzler.Screenscraper.Data.Models.ApiCredentials.DeveloperID')
  - [DeveloperPassword](#P-stigzler-Screenscraper-Data-Models-ApiCredentials-DeveloperPassword 'stigzler.Screenscraper.Data.Models.ApiCredentials.DeveloperPassword')
  - [DeveloperSoftware](#P-stigzler-Screenscraper-Data-Models-ApiCredentials-DeveloperSoftware 'stigzler.Screenscraper.Data.Models.ApiCredentials.DeveloperSoftware')
  - [UserID](#P-stigzler-Screenscraper-Data-Models-ApiCredentials-UserID 'stigzler.Screenscraper.Data.Models.ApiCredentials.UserID')
  - [UserPassword](#P-stigzler-Screenscraper-Data-Models-ApiCredentials-UserPassword 'stigzler.Screenscraper.Data.Models.ApiCredentials.UserPassword')
- [ApiDataService](#T-stigzler-Screenscraper-Services-ApiDataService 'stigzler.Screenscraper.Services.ApiDataService')
  - [GetStrings(objectUris,objectName,cancellationToken,progress)](#M-stigzler-Screenscraper-Services-ApiDataService-GetStrings-System-Collections-Generic-Dictionary{System-String,System-Uri},System-String,System-Nullable{System-Threading-CancellationToken},System-IProgress{stigzler-Screenscraper-EventArgs-ProgressChangedEventArgs}- 'stigzler.Screenscraper.Services.ApiDataService.GetStrings(System.Collections.Generic.Dictionary{System.String,System.Uri},System.String,System.Nullable{System.Threading.CancellationToken},System.IProgress{stigzler.Screenscraper.EventArgs.ProgressChangedEventArgs})')
- [ApiGetOutcome](#T-stigzler-Screenscraper-Data-Models-ApiGetOutcome 'stigzler.Screenscraper.Data.Models.ApiGetOutcome')
  - [Data](#F-stigzler-Screenscraper-Data-Models-ApiGetOutcome-Data 'stigzler.Screenscraper.Data.Models.ApiGetOutcome.Data')
  - [Exception](#F-stigzler-Screenscraper-Data-Models-ApiGetOutcome-Exception 'stigzler.Screenscraper.Data.Models.ApiGetOutcome.Exception')
  - [StatusCode](#F-stigzler-Screenscraper-Data-Models-ApiGetOutcome-StatusCode 'stigzler.Screenscraper.Data.Models.ApiGetOutcome.StatusCode')
  - [Successfull](#F-stigzler-Screenscraper-Data-Models-ApiGetOutcome-Successfull 'stigzler.Screenscraper.Data.Models.ApiGetOutcome.Successfull')
  - [Uri](#F-stigzler-Screenscraper-Data-Models-ApiGetOutcome-Uri 'stigzler.Screenscraper.Data.Models.ApiGetOutcome.Uri')
- [ApiQueryType](#T-stigzler-Screenscraper-Enums-ApiQueryType 'stigzler.Screenscraper.Enums.ApiQueryType')
  - [GameInfoList](#F-stigzler-Screenscraper-Enums-ApiQueryType-GameInfoList 'stigzler.Screenscraper.Enums.ApiQueryType.GameInfoList')
  - [GameVideoDownload](#F-stigzler-Screenscraper-Enums-ApiQueryType-GameVideoDownload 'stigzler.Screenscraper.Enums.ApiQueryType.GameVideoDownload')
- [ApiSearchParameters](#T-stigzler-Screenscraper-Data-Models-ApiSearchParameters 'stigzler.Screenscraper.Data.Models.ApiSearchParameters')
  - [CRC](#P-stigzler-Screenscraper-Data-Models-ApiSearchParameters-CRC 'stigzler.Screenscraper.Data.Models.ApiSearchParameters.CRC')
  - [GameID](#P-stigzler-Screenscraper-Data-Models-ApiSearchParameters-GameID 'stigzler.Screenscraper.Data.Models.ApiSearchParameters.GameID')
  - [GameName](#P-stigzler-Screenscraper-Data-Models-ApiSearchParameters-GameName 'stigzler.Screenscraper.Data.Models.ApiSearchParameters.GameName')
  - [MD5](#P-stigzler-Screenscraper-Data-Models-ApiSearchParameters-MD5 'stigzler.Screenscraper.Data.Models.ApiSearchParameters.MD5')
  - [RomFileType](#P-stigzler-Screenscraper-Data-Models-ApiSearchParameters-RomFileType 'stigzler.Screenscraper.Data.Models.ApiSearchParameters.RomFileType')
  - [RomName](#P-stigzler-Screenscraper-Data-Models-ApiSearchParameters-RomName 'stigzler.Screenscraper.Data.Models.ApiSearchParameters.RomName')
  - [RomSize](#P-stigzler-Screenscraper-Data-Models-ApiSearchParameters-RomSize 'stigzler.Screenscraper.Data.Models.ApiSearchParameters.RomSize')
  - [SHA1](#P-stigzler-Screenscraper-Data-Models-ApiSearchParameters-SHA1 'stigzler.Screenscraper.Data.Models.ApiSearchParameters.SHA1')
  - [SerialNumber](#P-stigzler-Screenscraper-Data-Models-ApiSearchParameters-SerialNumber 'stigzler.Screenscraper.Data.Models.ApiSearchParameters.SerialNumber')
  - [SystemID](#P-stigzler-Screenscraper-Data-Models-ApiSearchParameters-SystemID 'stigzler.Screenscraper.Data.Models.ApiSearchParameters.SystemID')
- [ApiServerParameters](#T-stigzler-Screenscraper-Data-Models-ApiServerParameters 'stigzler.Screenscraper.Data.Models.ApiServerParameters')
  - [ApiPath](#P-stigzler-Screenscraper-Data-Models-ApiServerParameters-ApiPath 'stigzler.Screenscraper.Data.Models.ApiServerParameters.ApiPath')
  - [HostAddress](#P-stigzler-Screenscraper-Data-Models-ApiServerParameters-HostAddress 'stigzler.Screenscraper.Data.Models.ApiServerParameters.HostAddress')
  - [HttpTimeout](#P-stigzler-Screenscraper-Data-Models-ApiServerParameters-HttpTimeout 'stigzler.Screenscraper.Data.Models.ApiServerParameters.HttpTimeout')
- [GetData](#T-stigzler-Screenscraper-GetData 'stigzler.Screenscraper.GetData')
  - [#ctor(credentials,apiServerParameters,userThreads)](#M-stigzler-Screenscraper-GetData-#ctor-stigzler-Screenscraper-Data-Models-ApiCredentials,stigzler-Screenscraper-Data-Models-ApiServerParameters,System-Int32- 'stigzler.Screenscraper.GetData.#ctor(stigzler.Screenscraper.Data.Models.ApiCredentials,stigzler.Screenscraper.Data.Models.ApiServerParameters,System.Int32)')
  - [ApiParameters](#P-stigzler-Screenscraper-GetData-ApiParameters 'stigzler.Screenscraper.GetData.ApiParameters')
  - [Credentials](#P-stigzler-Screenscraper-GetData-Credentials 'stigzler.Screenscraper.GetData.Credentials')
  - [MetadataOutputFormat](#P-stigzler-Screenscraper-GetData-MetadataOutputFormat 'stigzler.Screenscraper.GetData.MetadataOutputFormat')
  - [UserThreads](#P-stigzler-Screenscraper-GetData-UserThreads 'stigzler.Screenscraper.GetData.UserThreads')
  - [GetFile(queryType,downloadParameters,destinationFilename)](#M-stigzler-Screenscraper-GetData-GetFile-stigzler-Screenscraper-Enums-ApiQueryType,stigzler-Screenscraper-Data-Models-APIDownloadParameters,System-String- 'stigzler.Screenscraper.GetData.GetFile(stigzler.Screenscraper.Enums.ApiQueryType,stigzler.Screenscraper.Data.Models.APIDownloadParameters,System.String)')
  - [GetGameInfo(gameSearchParameters,queryType,cancellationToken,progress)](#M-stigzler-Screenscraper-GetData-GetGameInfo-stigzler-Screenscraper-Data-Models-ApiSearchParameters,stigzler-Screenscraper-Enums-ApiQueryType,System-Nullable{System-Threading-CancellationToken},System-IProgress{stigzler-Screenscraper-EventArgs-ProgressChangedEventArgs}- 'stigzler.Screenscraper.GetData.GetGameInfo(stigzler.Screenscraper.Data.Models.ApiSearchParameters,stigzler.Screenscraper.Enums.ApiQueryType,System.Nullable{System.Threading.CancellationToken},System.IProgress{stigzler.Screenscraper.EventArgs.ProgressChangedEventArgs})')
  - [GetGamesInfo(gameSearchParametersList,queryType,cancellationToken,progress)](#M-stigzler-Screenscraper-GetData-GetGamesInfo-System-Collections-Generic-List{stigzler-Screenscraper-Data-Models-ApiSearchParameters},stigzler-Screenscraper-Enums-ApiQueryType,System-Nullable{System-Threading-CancellationToken},System-IProgress{stigzler-Screenscraper-EventArgs-ProgressChangedEventArgs}- 'stigzler.Screenscraper.GetData.GetGamesInfo(System.Collections.Generic.List{stigzler.Screenscraper.Data.Models.ApiSearchParameters},stigzler.Screenscraper.Enums.ApiQueryType,System.Nullable{System.Threading.CancellationToken},System.IProgress{stigzler.Screenscraper.EventArgs.ProgressChangedEventArgs})')
- [ProgressChangedEventArgs](#T-stigzler-Screenscraper-EventArgs-ProgressChangedEventArgs 'stigzler.Screenscraper.EventArgs.ProgressChangedEventArgs')
  - [DataObject](#P-stigzler-Screenscraper-EventArgs-ProgressChangedEventArgs-DataObject 'stigzler.Screenscraper.EventArgs.ProgressChangedEventArgs.DataObject')
  - [ProgressPercentage](#P-stigzler-Screenscraper-EventArgs-ProgressChangedEventArgs-ProgressPercentage 'stigzler.Screenscraper.EventArgs.ProgressChangedEventArgs.ProgressPercentage')
  - [Rate](#P-stigzler-Screenscraper-EventArgs-ProgressChangedEventArgs-Rate 'stigzler.Screenscraper.EventArgs.ProgressChangedEventArgs.Rate')
  - [Uri](#P-stigzler-Screenscraper-EventArgs-ProgressChangedEventArgs-Uri 'stigzler.Screenscraper.EventArgs.ProgressChangedEventArgs.Uri')
- [QueryMismatchException](#T-stigzler-Screenscraper-Exceptions-QueryMismatchException 'stigzler.Screenscraper.Exceptions.QueryMismatchException')
  - [AcceptedQueryTypes](#P-stigzler-Screenscraper-Exceptions-QueryMismatchException-AcceptedQueryTypes 'stigzler.Screenscraper.Exceptions.QueryMismatchException.AcceptedQueryTypes')
  - [AttemptedQueryType](#P-stigzler-Screenscraper-Exceptions-QueryMismatchException-AttemptedQueryType 'stigzler.Screenscraper.Exceptions.QueryMismatchException.AttemptedQueryType')
  - [CorrectGroup](#P-stigzler-Screenscraper-Exceptions-QueryMismatchException-CorrectGroup 'stigzler.Screenscraper.Exceptions.QueryMismatchException.CorrectGroup')
- [WebClient](#T-stigzler-Screenscraper-ModifiedNet-WebClient 'stigzler.Screenscraper.ModifiedNet.WebClient')
  - [Timeout](#P-stigzler-Screenscraper-ModifiedNet-WebClient-Timeout 'stigzler.Screenscraper.ModifiedNet.WebClient.Timeout')

<a name='T-stigzler-Screenscraper-Data-Models-APIDownloadParameters'></a>
## APIDownloadParameters `type`

##### Namespace

stigzler.Screenscraper.Data.Models

<a name='P-stigzler-Screenscraper-Data-Models-APIDownloadParameters-CRC'></a>
### CRC `property`

##### Summary

CRC of the media file

<a name='P-stigzler-Screenscraper-Data-Models-APIDownloadParameters-MD5'></a>
### MD5 `property`

##### Summary

MD5 of the media file

<a name='P-stigzler-Screenscraper-Data-Models-APIDownloadParameters-MediaFormat'></a>
### MediaFormat `property`

##### Summary

Media format (e.g. "png")

<a name='P-stigzler-Screenscraper-Data-Models-APIDownloadParameters-MediaTypeName'></a>
### MediaTypeName `property`

##### Summary

The name of the Media Item to download (e.g. "Wheel(wor)").

<a name='P-stigzler-Screenscraper-Data-Models-APIDownloadParameters-ObjectID'></a>
### ObjectID `property`

##### Summary

ID of the relevant object. E.g. for GameImages query this would be the GameID. For GameOrganisationImages, the OrganisationID

<a name='P-stigzler-Screenscraper-Data-Models-APIDownloadParameters-SHA1'></a>
### SHA1 `property`

##### Summary

SHA1 of the media file

<a name='P-stigzler-Screenscraper-Data-Models-APIDownloadParameters-SystemID'></a>
### SystemID `property`

##### Summary

SystemID of the related system

<a name='T-stigzler-Screenscraper-Data-Models-ApiCredentials'></a>
## ApiCredentials `type`

##### Namespace

stigzler.Screenscraper.Data.Models

##### Summary

User credentials for use with the ScreenScraper API

<a name='P-stigzler-Screenscraper-Data-Models-ApiCredentials-DeveloperID'></a>
### DeveloperID `property`

##### Summary

The Api Developer ID

<a name='P-stigzler-Screenscraper-Data-Models-ApiCredentials-DeveloperPassword'></a>
### DeveloperPassword `property`

##### Summary

The Api Developer Password

<a name='P-stigzler-Screenscraper-Data-Models-ApiCredentials-DeveloperSoftware'></a>
### DeveloperSoftware `property`

##### Summary

The ApiKey Developer Software Name

<a name='P-stigzler-Screenscraper-Data-Models-ApiCredentials-UserID'></a>
### UserID `property`

##### Summary

The ScreenScraper User ID

<a name='P-stigzler-Screenscraper-Data-Models-ApiCredentials-UserPassword'></a>
### UserPassword `property`

##### Summary

The ScreenScraper User Password

<a name='T-stigzler-Screenscraper-Services-ApiDataService'></a>
## ApiDataService `type`

##### Namespace

stigzler.Screenscraper.Services

<a name='M-stigzler-Screenscraper-Services-ApiDataService-GetStrings-System-Collections-Generic-Dictionary{System-String,System-Uri},System-String,System-Nullable{System-Threading-CancellationToken},System-IProgress{stigzler-Screenscraper-EventArgs-ProgressChangedEventArgs}-'></a>
### GetStrings(objectUris,objectName,cancellationToken,progress) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| objectUris | [System.Collections.Generic.Dictionary{System.String,System.Uri}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary 'System.Collections.Generic.Dictionary{System.String,System.Uri}') | Dictionary of string,Uri where the string value is used in the progress report. E.g. "Wipeout.7z" for roms or "Wipeout" for Gamename |
| objectName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Used in the constructing the progress report. E.g. "rom" will result in "Processing rom" |
| cancellationToken | [System.Nullable{System.Threading.CancellationToken}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Threading.CancellationToken}') |  |
| progress | [System.IProgress{stigzler.Screenscraper.EventArgs.ProgressChangedEventArgs}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IProgress 'System.IProgress{stigzler.Screenscraper.EventArgs.ProgressChangedEventArgs}') |  |

<a name='T-stigzler-Screenscraper-Data-Models-ApiGetOutcome'></a>
## ApiGetOutcome `type`

##### Namespace

stigzler.Screenscraper.Data.Models

##### Summary

API query results. This provides a data object to the consumer which holds details
of the outcome of any API Get calls.

<a name='F-stigzler-Screenscraper-Data-Models-ApiGetOutcome-Data'></a>
### Data `constants`

##### Summary

This varies depending on the `ApiQueryGroup`:

<a name='F-stigzler-Screenscraper-Data-Models-ApiGetOutcome-Exception'></a>
### Exception `constants`

##### Summary

If an exception is raised from the query, it is returned via this property

<a name='F-stigzler-Screenscraper-Data-Models-ApiGetOutcome-StatusCode'></a>
### StatusCode `constants`

##### Summary

The http status code that results from the query. -1 means error wasn't from a HttpError

<a name='F-stigzler-Screenscraper-Data-Models-ApiGetOutcome-Successfull'></a>
### Successfull `constants`

##### Summary

Returns whether the operation is successful. The definition of success varies by
query type.

E.g. a successful GameImageDownload if that the file was found and downloaded.
A successful GameRomSearch is if a match was found.

<a name='F-stigzler-Screenscraper-Data-Models-ApiGetOutcome-Uri'></a>
### Uri `constants`

##### Summary

The Query Uri used

<a name='T-stigzler-Screenscraper-Enums-ApiQueryType'></a>
## ApiQueryType `type`

##### Namespace

stigzler.Screenscraper.Enums

<a name='F-stigzler-Screenscraper-Enums-ApiQueryType-GameInfoList'></a>
### GameInfoList `constants`

##### Summary

This returns the different types of game information.

Eg. Family, Mode, Number, Resolution, Themes

<a name='F-stigzler-Screenscraper-Enums-ApiQueryType-GameVideoDownload'></a>
### GameVideoDownload `constants`

##### Summary

Downloads video for specified Game. 
Requires `ApiQueryParameters:` SystemID, GameID, MediaTypeName

<a name='T-stigzler-Screenscraper-Data-Models-ApiSearchParameters'></a>
## ApiSearchParameters `type`

##### Namespace

stigzler.Screenscraper.Data.Models

##### Summary

Used interchangeably with ApiQueryType.GameNameSearch and ApiQueryType.GameRomSearch. 
Not all properties need to be set.

<a name='P-stigzler-Screenscraper-Data-Models-ApiSearchParameters-CRC'></a>
### CRC `property`

##### Summary

CRC of the game rom

<a name='P-stigzler-Screenscraper-Data-Models-ApiSearchParameters-GameID'></a>
### GameID `property`

##### Summary

The ID of the Game being searched for.

<a name='P-stigzler-Screenscraper-Data-Models-ApiSearchParameters-GameName'></a>
### GameName `property`

##### Summary

The Game Name to search for. Used with ApiQueryType.GameNameSearch.

<a name='P-stigzler-Screenscraper-Data-Models-ApiSearchParameters-MD5'></a>
### MD5 `property`

##### Summary

MD5 of the game rom

<a name='P-stigzler-Screenscraper-Data-Models-ApiSearchParameters-RomFileType'></a>
### RomFileType `property`

##### Summary

The type of rom to search for. Types are those returned by ApiQueryType.RomFileTypesList

<a name='P-stigzler-Screenscraper-Data-Models-ApiSearchParameters-RomName'></a>
### RomName `property`

##### Summary

The game Rom to search for. Used with ApiQueryType.GameRomSearch.

<a name='P-stigzler-Screenscraper-Data-Models-ApiSearchParameters-RomSize'></a>
### RomSize `property`

##### Summary

Size of the rom in Bytes

<a name='P-stigzler-Screenscraper-Data-Models-ApiSearchParameters-SHA1'></a>
### SHA1 `property`

##### Summary

SHA1 of the game rom

<a name='P-stigzler-Screenscraper-Data-Models-ApiSearchParameters-SerialNumber'></a>
### SerialNumber `property`

##### Summary

Not clear on this - Screenscraper API page states: 
"Force search for the game with the number serial of the rom (iso) associated"

<a name='P-stigzler-Screenscraper-Data-Models-ApiSearchParameters-SystemID'></a>
### SystemID `property`

##### Summary

SystemID of the related system

<a name='T-stigzler-Screenscraper-Data-Models-ApiServerParameters'></a>
## ApiServerParameters `type`

##### Namespace

stigzler.Screenscraper.Data.Models

<a name='P-stigzler-Screenscraper-Data-Models-ApiServerParameters-ApiPath'></a>
### ApiPath `property`

##### Summary

The path to the api from the HostAddress.

Example: "api2"

<a name='P-stigzler-Screenscraper-Data-Models-ApiServerParameters-HostAddress'></a>
### HostAddress `property`

##### Summary

The base address of the screenscraper API.

Example: "https://www.screenscraper.fr"

<a name='P-stigzler-Screenscraper-Data-Models-ApiServerParameters-HttpTimeout'></a>
### HttpTimeout `property`

##### Summary

This sets the timeout for the web request in milliseconds.

<a name='T-stigzler-Screenscraper-GetData'></a>
## GetData `type`

##### Namespace

stigzler.Screenscraper

##### Summary

This is the main Class used to retrieve data from the 
ScreenScraper.fr API.
Commonly, all Get requests take [ApiQueryType](#T-stigzler-Screenscraper-Enums-ApiQueryType 'stigzler.Screenscraper.Enums.ApiQueryType').

<a name='M-stigzler-Screenscraper-GetData-#ctor-stigzler-Screenscraper-Data-Models-ApiCredentials,stigzler-Screenscraper-Data-Models-ApiServerParameters,System-Int32-'></a>
### #ctor(credentials,apiServerParameters,userThreads) `constructor`

##### Summary

The main method used to retrieve data from the 
ScreenScraper API.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| credentials | [stigzler.Screenscraper.Data.Models.ApiCredentials](#T-stigzler-Screenscraper-Data-Models-ApiCredentials 'stigzler.Screenscraper.Data.Models.ApiCredentials') | API and User credentials |
| apiServerParameters | [stigzler.Screenscraper.Data.Models.ApiServerParameters](#T-stigzler-Screenscraper-Data-Models-ApiServerParameters 'stigzler.Screenscraper.Data.Models.ApiServerParameters') | API and Query Server Parameters |
| userThreads | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Specify number of API threads available to the user's account |

<a name='P-stigzler-Screenscraper-GetData-ApiParameters'></a>
### ApiParameters `property`

##### Summary

Api specific parameters. [ApiServerParameters](#T-stigzler-Screenscraper-Data-Models-ApiServerParameters 'stigzler.Screenscraper.Data.Models.ApiServerParameters')

<a name='P-stigzler-Screenscraper-GetData-Credentials'></a>
### Credentials `property`

##### Summary

Api and User credentials for accessing the API.

<a name='P-stigzler-Screenscraper-GetData-MetadataOutputFormat'></a>
### MetadataOutputFormat `property`

##### Summary

What format for any metadata output (xml or json)

<a name='P-stigzler-Screenscraper-GetData-UserThreads'></a>
### UserThreads `property`

##### Summary

How many threads the screenscraper User has available when using the API

<a name='M-stigzler-Screenscraper-GetData-GetFile-stigzler-Screenscraper-Enums-ApiQueryType,stigzler-Screenscraper-Data-Models-APIDownloadParameters,System-String-'></a>
### GetFile(queryType,downloadParameters,destinationFilename) `method`

##### Summary

Downloads a file if one available. Covers various download functions for 
Game and System Images/Videos/Manuals/Company/Genre etc

##### Returns

An ApiGetOutcome object containing pertinent results of the Get request. The ApiGetOutcome.Data in this case is the returned xml/json or any error message

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| queryType | [stigzler.Screenscraper.Enums.ApiQueryType](#T-stigzler-Screenscraper-Enums-ApiQueryType 'stigzler.Screenscraper.Enums.ApiQueryType') | The type of Download Query. |
| downloadParameters | [stigzler.Screenscraper.Data.Models.APIDownloadParameters](#T-stigzler-Screenscraper-Data-Models-APIDownloadParameters 'stigzler.Screenscraper.Data.Models.APIDownloadParameters') | Parameters related to the download. |
| destinationFilename | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The full filename to save the file as (with path, filename and extension). |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [stigzler.Screenscraper.Exceptions.QueryMismatchException](#T-stigzler-Screenscraper-Exceptions-QueryMismatchException 'stigzler.Screenscraper.Exceptions.QueryMismatchException') | QueryMismatchException thrown if wrong form of query sent to this method. Only takes download queries. |

<a name='M-stigzler-Screenscraper-GetData-GetGameInfo-stigzler-Screenscraper-Data-Models-ApiSearchParameters,stigzler-Screenscraper-Enums-ApiQueryType,System-Nullable{System-Threading-CancellationToken},System-IProgress{stigzler-Screenscraper-EventArgs-ProgressChangedEventArgs}-'></a>
### GetGameInfo(gameSearchParameters,queryType,cancellationToken,progress) `method`

##### Summary

Gets game information via romname or gamename. 
Query types supported: GameNameSearch, GameRomSearch

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| gameSearchParameters | [stigzler.Screenscraper.Data.Models.ApiSearchParameters](#T-stigzler-Screenscraper-Data-Models-ApiSearchParameters 'stigzler.Screenscraper.Data.Models.ApiSearchParameters') | Parameters for the game search |
| queryType | [stigzler.Screenscraper.Enums.ApiQueryType](#T-stigzler-Screenscraper-Enums-ApiQueryType 'stigzler.Screenscraper.Enums.ApiQueryType') | Type of query to return. Query types supported: GameNameSearch, GameRomSearch |
| cancellationToken | [System.Nullable{System.Threading.CancellationToken}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Threading.CancellationToken}') | Any cancellation token |
| progress | [System.IProgress{stigzler.Screenscraper.EventArgs.ProgressChangedEventArgs}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IProgress 'System.IProgress{stigzler.Screenscraper.EventArgs.ProgressChangedEventArgs}') | IProgress object for updates on progress. |

<a name='M-stigzler-Screenscraper-GetData-GetGamesInfo-System-Collections-Generic-List{stigzler-Screenscraper-Data-Models-ApiSearchParameters},stigzler-Screenscraper-Enums-ApiQueryType,System-Nullable{System-Threading-CancellationToken},System-IProgress{stigzler-Screenscraper-EventArgs-ProgressChangedEventArgs}-'></a>
### GetGamesInfo(gameSearchParametersList,queryType,cancellationToken,progress) `method`

##### Summary

Gets game information via romname or gamename. 
Query types supported: GameNameSearch, GameRomSearch

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| gameSearchParametersList | [System.Collections.Generic.List{stigzler.Screenscraper.Data.Models.ApiSearchParameters}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{stigzler.Screenscraper.Data.Models.ApiSearchParameters}') | Parameters for each game search |
| queryType | [stigzler.Screenscraper.Enums.ApiQueryType](#T-stigzler-Screenscraper-Enums-ApiQueryType 'stigzler.Screenscraper.Enums.ApiQueryType') | Type of query to return. Query types supported: GameNameSearch, GameRomSearch |
| cancellationToken | [System.Nullable{System.Threading.CancellationToken}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Threading.CancellationToken}') | Any cancellation token |
| progress | [System.IProgress{stigzler.Screenscraper.EventArgs.ProgressChangedEventArgs}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IProgress 'System.IProgress{stigzler.Screenscraper.EventArgs.ProgressChangedEventArgs}') | IProgress object for updates on progress |

<a name='T-stigzler-Screenscraper-EventArgs-ProgressChangedEventArgs'></a>
## ProgressChangedEventArgs `type`

##### Namespace

stigzler.Screenscraper.EventArgs

<a name='P-stigzler-Screenscraper-EventArgs-ProgressChangedEventArgs-DataObject'></a>
### DataObject `property`

##### Summary

Detail of the data object being proceeded. E.g. RomFilename or GameName

<a name='P-stigzler-Screenscraper-EventArgs-ProgressChangedEventArgs-ProgressPercentage'></a>
### ProgressPercentage `property`

##### Summary

Percentage progress of precessed to total objects

<a name='P-stigzler-Screenscraper-EventArgs-ProgressChangedEventArgs-Rate'></a>
### Rate `property`

##### Summary

The number of objects per second

<a name='P-stigzler-Screenscraper-EventArgs-ProgressChangedEventArgs-Uri'></a>
### Uri `property`

##### Summary

The linked URI

<a name='T-stigzler-Screenscraper-Exceptions-QueryMismatchException'></a>
## QueryMismatchException `type`

##### Namespace

stigzler.Screenscraper.Exceptions

<a name='P-stigzler-Screenscraper-Exceptions-QueryMismatchException-AcceptedQueryTypes'></a>
### AcceptedQueryTypes `property`

##### Summary

List of permitted query types.

<a name='P-stigzler-Screenscraper-Exceptions-QueryMismatchException-AttemptedQueryType'></a>
### AttemptedQueryType `property`

##### Summary

The attempted query type.

<a name='P-stigzler-Screenscraper-Exceptions-QueryMismatchException-CorrectGroup'></a>
### CorrectGroup `property`

##### Summary

The group that permitted query types belongs to.

<a name='T-stigzler-Screenscraper-ModifiedNet-WebClient'></a>
## WebClient `type`

##### Namespace

stigzler.Screenscraper.ModifiedNet

<a name='P-stigzler-Screenscraper-ModifiedNet-WebClient-Timeout'></a>
### Timeout `property`

##### Summary

Timeout to apply in milliseconds
