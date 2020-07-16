#if !UNITY_ANDROID && !UNITY_IOS

namespace Plugins.UXCam
{

    public class UXCam
    {
        public static void StartWithKey(string key) { }

        public static void OptIntoSchematicRecordings() { }

        /// <summary>
        /// Gives callback with session url when session starts successfully on objectMethod. Note: Won't trigger if object not active/destroyed
        /// </summary>
        /// <param name="key">App key</param>
        /// <param name="objectName">Name of the object currently active in scene</param>
        /// <param name="objectMethod">Method inside script attached to the object</param>
        public static void StartWithKeyCallback(string key, string objectName, string objectMethod) { }

        public static void StartNewSession() { }

        public static void HideSensitiveScreen(bool hide) { }

        public static void HideSensitiveScreenWithoutGestures(bool hideScreen, bool hideGesture) { }

        public static void SetUserIdentity(string userIdentity) { }

        public static void SetUserProperty(string key, string value) { }

        public static void LogEvent(string eventName) { }

        public static void SetAutomaticScreenTagging(bool isEnabled) { }

        public static void TagScreenName(string screenName) { }

        public static void StopSessionAndUploadData() { }

        /// <summary>
        /// Gives callback when session upload completes on objectMethod. Note: Won't trigger if object not active/destroyed
        /// </summary>
        /// <param name="objectName">Name of the object currently active in scene</param>
        /// <param name="objectMethod">Method inside script attached to the object</param>
        public static void StopSessionAndUploadDataCallback(string objectName, string objectMethod) { }

        public static void AllowShortBreakForAnotherApp(bool isAllowed) { }

        public static void CancelCurrentSession() { }

        public static bool GetMultiSessionRecord()
        {
            return false;
        }

        public static void SetMultiSessionRecord(bool recordMultipleSession) { }

        public static ulong PendingUploads()
        {
            return 0;
        }

        public static void DeletePendingUploads() { }

        /// <summary>
        /// IOS only
        /// </summary>
        public static void UploadPendingSession() { }

        /// <summary>
        /// IOS only. Gives callback when session upload completes on objectMethod. Note: Won't trigger if object not active/destroyed
        /// </summary>
        /// <param name="objectName">Name of the object currently active in scene</param>
        /// <param name="objectMethod">Method inside script attached to the object</param>
        public static void UploadPendingSessionCallback(string objectName, string objectMethod) { }

        public static string UrlForCurrentSession()
        {
            return "";
        }

        public static string UrlForCurrentUser()
        {
            return "";
        }

        /// <summary>
        /// Log event name and its associated properties
        /// </summary>
        /// <param name="eventName">Name of the event</param>
        /// <param name="eventProperties">Event properties. Stringify dictionary or object for multitple properties</param>
        public static void LogEventWithProperties(string eventName, string eventProperties) { }

        /// <summary>
        /// For ios only. Not available for android
        /// </summary>
        /// <param name="disable"></param>
        public static void DisableCrashHanding(bool disable) { }
    }
}

#endif