#import <Foundation/Foundation.h>
#import <UXCam/UXCam.h>
#import <UnityAppController.h>


extern "C" {

    void optIntoSchematicRecordings(){
        [UXCam optIntoSchematicRecordings];
    }

    void startWithKey(const char* appKey){
        [UXCam startWithKey:[NSString stringWithUTF8String:appKey]];
    }

    void startWithKeyCallback(const char* appKey, const char* objectName, const char* objectMethod){
        
        NSString* objName = [NSString stringWithUTF8String:objectName];
        NSString* objMethod = [NSString stringWithUTF8String:objectMethod];
        
        [UXCam startWithKey:[NSString stringWithUTF8String:appKey] buildIdentifier:nil completionBlock:^(BOOL started) {
            if (started){
                const char* url = [[UXCam urlForCurrentSession] UTF8String];
                UnitySendMessage([objName UTF8String], [objMethod UTF8String], url);
            }
        }];
    }

    const char* convertToCString(const NSString* nsString)
    {
        if (nsString == NULL)
            return NULL;

        const char* nsStringUtf8 = [nsString UTF8String];
        char* cString = (char*)malloc(strlen(nsStringUtf8) + 1);
        strcpy(cString, nsStringUtf8);

        return cString;
    }

    const char* urlForCurrentSession(){
        return convertToCString([UXCam urlForCurrentSession]);
    }

    const char* urlForCurrentUser(){
        return convertToCString([UXCam urlForCurrentUser]);
    }

    void hideSensitiveScreen(bool hideScreen){
        [UXCam occludeSensitiveScreen:hideScreen];
    }

    void hideSensitiveScreenWithoutGestures(bool hideScreen, bool hideGestures){
        [UXCam occludeSensitiveScreen:hideScreen hideGestures:hideScreen];
    }

    void setUserIdentity(const char* userIdentity){
        [UXCam setUserIdentity:[NSString stringWithUTF8String:userIdentity]];
    }

    void setUserProperty(const char* key, const char* value){
        [UXCam setUserProperty:[NSString stringWithUTF8String:key] value:[NSString stringWithUTF8String:value]];
    }

    void logEvent(const char* eventName){
        [UXCam logEvent:[NSString stringWithUTF8String:eventName]];
    }

    void setAutomaticScreenTagging(bool isEnabled){
        [UXCam setAutomaticScreenNameTagging:isEnabled];
    }

    void tagScreenName(const char* screenName){
        [UXCam tagScreenName:[NSString stringWithUTF8String:screenName]];
    }

    void stopSessionAndUploadData(){
        [UXCam stopSessionAndUploadData:nil];
    }

    void stopSessionAndUploadDataCallback(const char* objectName, const char* objectMethod){
        
        NSString* objName = [NSString stringWithUTF8String:objectName];
        NSString* objMethod = [NSString stringWithUTF8String:objectMethod];
        
        [UXCam stopSessionAndUploadData:^{
            UnitySendMessage([objName UTF8String], [objMethod UTF8String], "");
        }];
    }

    void allowShortBreakForAnotherApp(bool isAllowed){
        [UXCam allowShortBreakForAnotherApp:isAllowed];
    }

    void cancelCurrentSession(){
        [UXCam cancelCurrentSession];
    }

    bool getMultiSessionRecord(){
        return [UXCam getMultiSessionRecord];
    }

    void setMultiSessionRecord(bool recordMultipleSession){
        [UXCam setMultiSessionRecord:recordMultipleSession];
    }

    unsigned long int pendingUploads(){
        return [UXCam pendingUploads];
    }

    void deletePendingUploads(){
        [UXCam deletePendingUploads];
    }

    void uploadPendingSession(){
        [UXCam uploadingPendingSessions:nil];
    }

    void uploadPendingSessionCallback(const char* objectName, const char* objectMethod){
        
        NSString* objName = [NSString stringWithUTF8String:objectName];
        NSString* objMethod = [NSString stringWithUTF8String:objectMethod];
        
        [UXCam uploadingPendingSessions:^{
            UnitySendMessage([objName UTF8String], [objMethod UTF8String], "");
        }];
    }

}
