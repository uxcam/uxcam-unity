
#if UNITY_IOS

namespace Plugins.UXCam
{
    using UnityEngine;
    using System.Runtime.InteropServices;

    public class UXCam
    {

        [DllImport("__Internal")]
        private static extern void startWithKey(string key);

        [DllImport("__Internal")]
        private static extern void optIntoSchematicRecordings();

        [DllImport("__Internal")]
        private static extern double startWithKeyCallback(string key, string objectName, string objectMethod);

        [DllImport("__Internal")]
        private static extern void hideSensitiveScreen(bool hide);

        [DllImport("__Internal")]
        private static extern void hideSensitiveScreenWithoutGestures(bool hideScreen, bool hideGesture);

        [DllImport("__Internal")]
        private static extern void setUserIdentity(string userIdentity);

        [DllImport("__Internal")]
        private static extern void setUserProperty(string key, string value);

        [DllImport("__Internal")]
        private static extern void logEvent(string eventName);

        [DllImport("__Internal")]
        private static extern void setAutomaticScreenTagging(bool isEnabled);

        [DllImport("__Internal")]
        private static extern void tagScreenName(string screenName);

        [DllImport("__Internal")]
        private static extern void stopSessionAndUploadData();

        [DllImport("__Internal")]
        private static extern void stopSessionAndUploadDataCallback(string objectName, string objectMethod);

        [DllImport("__Internal")]
        private static extern void allowShortBreakForAnotherApp(bool isAllowed);

        [DllImport("__Internal")]
        private static extern void cancelCurrentSession();

        [DllImport("__Internal")]
        private static extern bool getMultiSessionRecord();

        [DllImport("__Internal")]
        private static extern void setMultiSessionRecord(bool recordMultipleSession);

        [DllImport("__Internal")]
        private static extern ulong pendingUploads();

        [DllImport("__Internal")]
        private static extern void deletePendingUploads();

        [DllImport("__Internal")]
        private static extern void uploadPendingSession();

        [DllImport("__Internal")]
        private static extern void uploadPendingSessionCallback(string objectName, string objectMethod);

        [DllImport("__Internal")]
        private static extern string urlForCurrentSession();

        [DllImport("__Internal")]
        private static extern string urlForCurrentUser();

        [DllImport("__Internal")]
        private static extern void startNewSession();

        [DllImport("__Internal")]
        private static extern void disableCrashHandling(bool disable);

        [DllImport("__Internal")]
        private static extern void addPluginType(string type, string version);

        [DllImport("__Internal")]
        private static extern void logEventWithProperties(string eventName, string eventProperties);


        public static void StartWithKey(string key)
        {
            if (Application.platform == RuntimePlatform.IPhonePlayer)
                //addPluginType("unity", "0.0.1");
                startWithKey(key);
        }

        public static void OptIntoSchematicRecordings()
        {
            if (Application.platform == RuntimePlatform.IPhonePlayer)
                optIntoSchematicRecordings();
        }

        /// <summary>
        /// Gives callback with session url when session starts successfully on objectMethod. Note: Won't trigger if object not active/destroyed
        /// </summary>
        /// <param name="key">App key</param>
        /// <param name="objectName">Name of the object currently active in scene</param>
        /// <param name="objectMethod">Method inside script attached to the object</param>
        public static void StartWithKeyCallback(string key, string objectName, string objectMethod)
        {
            if (Application.platform == RuntimePlatform.IPhonePlayer)
                //addPluginType("unity", "0.0.1");
                startWithKeyCallback(key, objectName, objectMethod);
        }

        public static void StartNewSession()
        {
            if (Application.platform == RuntimePlatform.IPhonePlayer)
                startNewSession();
        }

        public static void HideSensitiveScreen(bool hide)
        {
            if (Application.platform == RuntimePlatform.IPhonePlayer)
                hideSensitiveScreen(hide);
        }

        public static void HideSensitiveScreenWithoutGestures(bool hideScreen, bool hideGesture)
        {
            if (Application.platform == RuntimePlatform.IPhonePlayer)
                hideSensitiveScreenWithoutGestures(hideScreen, hideGesture);
        }

        public static void SetUserIdentity(string userIdentity)
        {
            if (Application.platform == RuntimePlatform.IPhonePlayer)
                setUserIdentity(userIdentity);
        }

        public static void SetUserProperty(string key, string value)
        {
            if (Application.platform == RuntimePlatform.IPhonePlayer)
                setUserProperty(key, value);
        }

        public static void LogEvent(string eventName)
        {
            if (Application.platform == RuntimePlatform.IPhonePlayer)
                logEvent(eventName);
        }

        public static void SetAutomaticScreenTagging(bool isEnabled)
        {
            if (Application.platform == RuntimePlatform.IPhonePlayer)
                setAutomaticScreenTagging(isEnabled);
        }

        public static void TagScreenName(string screenName)
        {
            if (Application.platform == RuntimePlatform.IPhonePlayer)
                tagScreenName(screenName);
        }

        public static void StopSessionAndUploadData()
        {
            if (Application.platform == RuntimePlatform.IPhonePlayer)
                stopSessionAndUploadData();
        }

        /// <summary>
        /// Gives callback when session upload completes on objectMethod. Note: Won't trigger if object not active/destroyed
        /// </summary>
        /// <param name="objectName">Name of the object currently active in scene</param>
        /// <param name="objectMethod">Method inside script attached to the object</param>
        public static void StopSessionAndUploadDataCallback(string objectName, string objectMethod)
        {
            if (Application.platform == RuntimePlatform.IPhonePlayer)
                stopSessionAndUploadDataCallback(objectName, objectMethod);
        }

        public static void AllowShortBreakForAnotherApp(bool isAllowed)
        {
            if (Application.platform == RuntimePlatform.IPhonePlayer)
                allowShortBreakForAnotherApp(isAllowed);
        }

        public static void CancelCurrentSession()
        {
            if (Application.platform == RuntimePlatform.IPhonePlayer)
                cancelCurrentSession();
        }

        public static bool GetMultiSessionRecord()
        {
            if (Application.platform == RuntimePlatform.IPhonePlayer)
                return getMultiSessionRecord();
            return false;
        }

        public static void SetMultiSessionRecord(bool recordMultipleSession)
        {
            if (Application.platform == RuntimePlatform.IPhonePlayer)
                setMultiSessionRecord(recordMultipleSession);
        }

        public static ulong PendingUploads()
        {
            if (Application.platform == RuntimePlatform.IPhonePlayer)
                return pendingUploads();
            return 0;
        }

        public static void DeletePendingUploads()
        {
            if (Application.platform == RuntimePlatform.IPhonePlayer)
                deletePendingUploads();
        }

        /// <summary>
        /// IOS only
        /// </summary>
        public static void UploadPendingSession()
        {
            if (Application.platform == RuntimePlatform.IPhonePlayer)
                uploadPendingSession();
        }

        /// <summary>
        /// IOS only. Gives callback when session upload completes on objectMethod. Note: Won't trigger if object not active/destroyed
        /// </summary>
        /// <param name="objectName">Name of the object currently active in scene</param>
        /// <param name="objectMethod">Method inside script attached to the object</param>
        public static void UploadPendingSessionCallback(string objectName, string objectMethod)
        {
            if (Application.platform == RuntimePlatform.IPhonePlayer)
                uploadPendingSessionCallback(objectName, objectMethod);
        }

        public static string UrlForCurrentSession()
        {
            if (Application.platform == RuntimePlatform.IPhonePlayer)
                return urlForCurrentSession();
            return "";
        }

        public static string UrlForCurrentUser()
        {
            if (Application.platform == RuntimePlatform.IPhonePlayer)
                return urlForCurrentUser();
            return "";
        }

        /// <summary>
        /// Log event name and its associated properties
        /// </summary>
        /// <param name="eventName">Name of the event</param>
        /// <param name="eventProperties">Event properties. Stringify dictionary or object for multitple properties</param>
        public static void LogEventWithProperties(string eventName, string eventProperties)
        {
            if (eventProperties == null)
                return;

            if (Application.platform == RuntimePlatform.IPhonePlayer)
                logEventWithProperties(eventName, eventProperties);
        }

        /// <summary>
        /// For ios only. Not available for android
        /// </summary>
        /// <param name="disable"></param>
        public static void DisableCrashHanding(bool disable)
        {
            if (Application.platform == RuntimePlatform.IPhonePlayer)
                disableCrashHandling(disable);
        }
    }
}
#endif