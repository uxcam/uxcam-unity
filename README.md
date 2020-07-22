# UXCam Unity
>Unity support is still in beta

## Installation

### iOS

- Add content of the iOS directory to your Assets/Plugins/iOS
- Add UXCamPluginIOS.cs and UXCamUnity.cs file inside your Assets/Plugins (recommended)
- Make sure **iOS** is selected as plugin platform on **Inspector window**

Inside **Inspector window -> Framework dependencies** for *UXCam.framework*, select: 
- Core Telephony
- MobileCoreServices
- Security
- WebKit

Inside your exported Xcode project, on **Build Phases -> Link Binary With Libraries** add **libz.tbd**.
>Make sure **libz.tbd** has *UnityFramework* set as *Target Membership*

### Android (not fully supported)
- Add content of the Android directory to your Assets/Plugins/Android
- Add UXCamPluginAndroid.cs and UXCamUnity.cs file inside your Assets/Plugins (recommended)
- Make sure **Android** is selected as plugin platform on **Inspector window**
>If you see any missing library error logs in android, make sure to add them in your module dependencies

## Usage
On your C# script, import
```
using Plugins.UXCam;
```

For starting a session
```
UXCam.OptIntoSchematicRecordings();
UXCam.StartWithKey("APP_KEY");
```

## API
API | iOS | Android | Description
----|----|----|----
StartWithKey | Yes | Yes | Start session with app key
StartWithKeyCallback | Yes | Yes | Start session with success/failure callback. Returns string value "true" on success
StartNewSession | Yes | Yes | Start new session
HideSensitiveScreen | Yes | Yes | Hide/unhide screen while sensitive view is present
HideSensitiveScreenWithoutGestures | Yes | Yes | Hide/unhide screen along with gestures
SetUserIdentity| Yes | Yes |Set user identity
SetUserProperty | Yes | Yes | Set property for current user
LogEvent | Yes | Yes| Log event
LogEventWithProperties |Yes | Yes | Log event with properties
SetAutomaticScreenTagging | Yes | Yes | Enable/disable automatic screen tagging
TagScreenName | Yes | Yes | Tag screen name
StopSessionAndUploadData | Yes | Yes | Stop current session and upload data
StopSessionAndUploadDataCallback| Yes | No | Stop current session and upload data with completion callback
AllowShortBreakForAnotherApp | Yes | Yes | Allow short break from app
CancelCurrentSession | Yes | Yes | Cancel current session
GetMultiSessionRecord | Yes | Yes | Get multiple session record status
SetMultiSessionRecord | Yes | Yes | Enable/disable multiple session 
PendingUploads | Yes | Yes | Get Pending uploads count
DeletePendingUploads | Yes | Yes | Delete pending uploads
UploadPendingSession | Yes | No | Upload pending session
UploadPendingSessionCallback | Yes | No | Upload pending session with completion callback
UrlForCurrentSession | Yes | Yes | Get URL for current session
UrlForCurrentUser | Yes | Yes | Get URL for current user
DisableCrashHanding | Yes | No | Disable crash handling
