# UXCam Unity

## Installation

### iOS

- Add content of iOS directory inside your Assets/Plugins/iOS
- Add UXCamPluginIOS.cs file inside your Assets/Plugins (or anywhere inside your project)

Inside **Inspector window -> Framework dependencies** for *UXCam.framework*, select: 
- Core Telephony
- MobileCoreServices
- Security
- WebKit

Inside your exported Xcode project, on **Build Phases -> Link Binary With Libraries** add **libz.tbd**.
>Make sure libz.tbd has *UnityFramework* set as *Target Membership*

### Android
>Coming soon

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
