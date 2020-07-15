# UXCam Unity

## Installation

### iOS

- Add content of iOS directory inside your Assets/Plugins/iOS
- Add UXCamPluginIOS.cs file inside your Assets/Plugins (recommended)
- Make sure **iOS** is selected as plugin platform on **Inspector window**

Inside **Inspector window -> Framework dependencies** for *UXCam.framework*, select: 
- Core Telephony
- MobileCoreServices
- Security
- WebKit

Inside your exported Xcode project, on **Build Phases -> Link Binary With Libraries** add **libz.tbd**.
>Make sure libz.tbd has *UnityFramework* set as *Target Membership*

### Android
- Add content of Android directory inside your Assets/Plugins/Android
- Add UXCamPluginAndroid.cs file inside your Assets/Plugins (recommended)
- Make sure **Android** is selected as plugin platform on **Inspector window**
>If you see any missing library error logs in android, make sure to add them in your module dependencies

## Usage
On your C# script, import
```
using Plugins.UXCam;
```

For starting session
```
UXCam.OptIntoSchematicRecordings();
UXCam.StartWithKey("APP_KEY");
```

For starting session with success callback. Will return callback on objectMethod.
```
UXCam.OptIntoSchematicRecordings();
UXCam.StartWithKeyCallback("APP_KEY", <objectName>, <objectMethod>);
```
