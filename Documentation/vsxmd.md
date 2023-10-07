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
- [ApiDataService](#T-stigzler-Screenscraper-Services-ApiDataService 'stigzler.Screenscraper.Services.ApiDataService')
  - [GetStrings(objectUris,objectName,cancellationToken,progress)](#M-stigzler-Screenscraper-Services-ApiDataService-GetStrings-System-Collections-Generic-Dictionary{System-String,System-Uri},System-String,System-Threading-CancellationToken,System-IProgress{stigzler-Screenscraper-EventArgs-ProgressChangedEventArgs}- 'stigzler.Screenscraper.Services.ApiDataService.GetStrings(System.Collections.Generic.Dictionary{System.String,System.Uri},System.String,System.Threading.CancellationToken,System.IProgress{stigzler.Screenscraper.EventArgs.ProgressChangedEventArgs})')
- [ApiQueryType](#T-stigzler-Screenscraper-Enums-ApiQueryType 'stigzler.Screenscraper.Enums.ApiQueryType')
  - [GameInfoList](#F-stigzler-Screenscraper-Enums-ApiQueryType-GameInfoList 'stigzler.Screenscraper.Enums.ApiQueryType.GameInfoList')
  - [GameVideoDownload](#F-stigzler-Screenscraper-Enums-ApiQueryType-GameVideoDownload 'stigzler.Screenscraper.Enums.ApiQueryType.GameVideoDownload')
- [Credentials](#T-stigzler-Screenscraper-Data-Models-Credentials 'stigzler.Screenscraper.Data.Models.Credentials')
  - [DeveloperID](#P-stigzler-Screenscraper-Data-Models-Credentials-DeveloperID 'stigzler.Screenscraper.Data.Models.Credentials.DeveloperID')
  - [DeveloperPassword](#P-stigzler-Screenscraper-Data-Models-Credentials-DeveloperPassword 'stigzler.Screenscraper.Data.Models.Credentials.DeveloperPassword')
  - [DeveloperSoftware](#P-stigzler-Screenscraper-Data-Models-Credentials-DeveloperSoftware 'stigzler.Screenscraper.Data.Models.Credentials.DeveloperSoftware')
  - [UserID](#P-stigzler-Screenscraper-Data-Models-Credentials-UserID 'stigzler.Screenscraper.Data.Models.Credentials.UserID')
  - [UserPassword](#P-stigzler-Screenscraper-Data-Models-Credentials-UserPassword 'stigzler.Screenscraper.Data.Models.Credentials.UserPassword')
- [GetData](#T-stigzler-Screenscraper-GetData 'stigzler.Screenscraper.GetData')
  - [#ctor(credentials,apiServerParameters,userThreads)](#M-stigzler-Screenscraper-GetData-#ctor-stigzler-Screenscraper-Data-Models-Credentials,stigzler-Screenscraper-Data-Models-ApiServerParameters,System-Int32- 'stigzler.Screenscraper.GetData.#ctor(stigzler.Screenscraper.Data.Models.Credentials,stigzler.Screenscraper.Data.Models.ApiServerParameters,System.Int32)')
- [ProgressChangedEventArgs](#T-stigzler-Screenscraper-EventArgs-ProgressChangedEventArgs 'stigzler.Screenscraper.EventArgs.ProgressChangedEventArgs')
  - [DataObject](#P-stigzler-Screenscraper-EventArgs-ProgressChangedEventArgs-DataObject 'stigzler.Screenscraper.EventArgs.ProgressChangedEventArgs.DataObject')
  - [ProgressPercentage](#P-stigzler-Screenscraper-EventArgs-ProgressChangedEventArgs-ProgressPercentage 'stigzler.Screenscraper.EventArgs.ProgressChangedEventArgs.ProgressPercentage')
  - [Rate](#P-stigzler-Screenscraper-EventArgs-ProgressChangedEventArgs-Rate 'stigzler.Screenscraper.EventArgs.ProgressChangedEventArgs.Rate')
  - [Uri](#P-stigzler-Screenscraper-EventArgs-ProgressChangedEventArgs-Uri 'stigzler.Screenscraper.EventArgs.ProgressChangedEventArgs.Uri')
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

<a name='T-stigzler-Screenscraper-Services-ApiDataService'></a>
## ApiDataService `type`

##### Namespace

stigzler.Screenscraper.Services

<a name='M-stigzler-Screenscraper-Services-ApiDataService-GetStrings-System-Collections-Generic-Dictionary{System-String,System-Uri},System-String,System-Threading-CancellationToken,System-IProgress{stigzler-Screenscraper-EventArgs-ProgressChangedEventArgs}-'></a>
### GetStrings(objectUris,objectName,cancellationToken,progress) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| objectUris | [System.Collections.Generic.Dictionary{System.String,System.Uri}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary 'System.Collections.Generic.Dictionary{System.String,System.Uri}') | Dictionary of string,Uri where the string value is used in the progress report. E.g. "Wipeout.7z" for roms or "Wipeout" for Gamename |
| objectName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Used in the constructing the progress report. E.g. "rom" will result in "Processing rom" |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') |  |
| progress | [System.IProgress{stigzler.Screenscraper.EventArgs.ProgressChangedEventArgs}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IProgress 'System.IProgress{stigzler.Screenscraper.EventArgs.ProgressChangedEventArgs}') |  |

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

Downloads video for specified Game
Required: `ApiQueryParameters:` SystemID, GameID, MediaTypeName

<a name='T-stigzler-Screenscraper-Data-Models-Credentials'></a>
## Credentials `type`

##### Namespace

stigzler.Screenscraper.Data.Models

##### Summary

User credentials for use with the ScreenScraper API

<a name='P-stigzler-Screenscraper-Data-Models-Credentials-DeveloperID'></a>
### DeveloperID `property`

##### Summary

The Api Developer ID

<a name='P-stigzler-Screenscraper-Data-Models-Credentials-DeveloperPassword'></a>
### DeveloperPassword `property`

##### Summary

The Api Developer Password

<a name='P-stigzler-Screenscraper-Data-Models-Credentials-DeveloperSoftware'></a>
### DeveloperSoftware `property`

##### Summary

The ApiKey Developer Software Name

<a name='P-stigzler-Screenscraper-Data-Models-Credentials-UserID'></a>
### UserID `property`

##### Summary

The ScreenScraper User ID

<a name='P-stigzler-Screenscraper-Data-Models-Credentials-UserPassword'></a>
### UserPassword `property`

##### Summary

The ScreenScraper User Password

<a name='T-stigzler-Screenscraper-GetData'></a>
## GetData `type`

##### Namespace

stigzler.Screenscraper

##### Summary

This is the main Class used to retrieve data from the 
ScreenScraper.fr API.

<a name='M-stigzler-Screenscraper-GetData-#ctor-stigzler-Screenscraper-Data-Models-Credentials,stigzler-Screenscraper-Data-Models-ApiServerParameters,System-Int32-'></a>
### #ctor(credentials,apiServerParameters,userThreads) `constructor`

##### Summary

The main method used to retrieve data from the 
ScreenScraper API.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| credentials | [stigzler.Screenscraper.Data.Models.Credentials](#T-stigzler-Screenscraper-Data-Models-Credentials 'stigzler.Screenscraper.Data.Models.Credentials') | API and User credentials |
| apiServerParameters | [stigzler.Screenscraper.Data.Models.ApiServerParameters](#T-stigzler-Screenscraper-Data-Models-ApiServerParameters 'stigzler.Screenscraper.Data.Models.ApiServerParameters') | API and Query Server Parameters |
| userThreads | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Specify number of API threads available to the user's account |

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

<a name='T-stigzler-Screenscraper-ModifiedNet-WebClient'></a>
## WebClient `type`

##### Namespace

stigzler.Screenscraper.ModifiedNet

<a name='P-stigzler-Screenscraper-ModifiedNet-WebClient-Timeout'></a>
### Timeout `property`

##### Summary

Timeout to apply in milliseconds
