#if UNITY_ANDROID

namespace Plugins.UXCam{
    using UnityEngine;
    using System.Collections.Generic;

    public class UXCam
    {

        static AndroidJavaObject jc = new AndroidJavaClass("com.uxcam.UXCam");
        static AndroidJavaObject jw = new AndroidJavaClass("UXCamNativeBridgeAndroid");


        public static void StartWithKey(string key)
        {
            AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            AndroidJavaObject activity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
            if (Application.platform == RuntimePlatform.Android)
                //jc.CallStatic("pluginType", "unity", "0.0,1");
                jc.CallStatic("startApplicationWithKeyForCordova", activity, key);
        }

        public static void OptIntoSchematicRecordings(){}

        /// <summary>
        /// Gives callback with session url when session starts successfully on objectMethod. Note: Won't trigger if object not active/destroyed
        /// </summary>
        /// <param name="key">App key</param>
        /// <param name="objectName">Name of the object currently active in scene</param>
        /// <param name="objectMethod">Method inside script attached to the object</param>
        public static void StartWithKeyCallback(string key, string objectName, string objectMethod)
        {
            if (Application.platform == RuntimePlatform.Android)
                //jc.CallStatic("pluginType", "unity", "0.0,1");
                StartWithKey(key);
                jw.CallStatic("onVerificationListener", objectName, objectMethod);
        }

        public static void StartNewSession()
        {
            if (Application.platform == RuntimePlatform.Android)
                jc.CallStatic("startNewSession");
        }

        public static void HideSensitiveScreen(bool hide)
        {
            if (Application.platform == RuntimePlatform.Android)
                jc.CallStatic("hideSensitiveScreen");
        }

        public static void HideSensitiveScreenWithoutGestures(bool hideScreen, bool hideGesture)
        {
            if (Application.platform == RuntimePlatform.Android)
                jc.CallStatic("hideSensitiveScreenWithoutGestures",hideScreen, hideGesture);
        }

        public static void SetUserIdentity(string userIdentity)
        {
            if (Application.platform == RuntimePlatform.Android)
                jc.CallStatic("setUserIdentity", userIdentity);
        }

        public static void SetUserProperty(string key, string value)
        {
            if (Application.platform == RuntimePlatform.Android)
                jc.CallStatic("setUserProperty", key, value);
        }

        public static void LogEvent(string eventName)
        {
            if (Application.platform == RuntimePlatform.Android)
                jc.CallStatic("logEvent", eventName);
        }

        public static void SetAutomaticScreenTagging(bool isEnabled)
        {
            if (Application.platform == RuntimePlatform.Android)
                jc.CallStatic("setAutomaticScreenTagging", isEnabled);
        }

        public static void TagScreenName(string screenName)
        {
            if (Application.platform == RuntimePlatform.Android)
                jc.CallStatic("tagScreenName", screenName);
        }

        public static void StopSessionAndUploadData()
        {
            if (Application.platform == RuntimePlatform.Android)
                jc.CallStatic("stopSessionAndUploadData");
        }

        /// <summary>
        /// Gives callback when session upload completes on objectMethod. Note: Won't trigger if object not active/destroyed
        /// </summary>
        /// <param name="objectName">Name of the object currently active in scene</param>
        /// <param name="objectMethod">Method inside script attached to the object</param>
        public static void StopSessionAndUploadDataCallback(string objectName, string objectMethod)
        {
            //if (Application.platform == RuntimePlatform.Android)
            //    stopSessionAndUploadDataCallback(objectName, objectMethod);
        }

        public static void AllowShortBreakForAnotherApp(bool isAllowed)
        {
            if (Application.platform == RuntimePlatform.Android)
                jc.CallStatic("allowShortBreakForAnotherApp", isAllowed);
        }

        public static void CancelCurrentSession()
        {
            if (Application.platform == RuntimePlatform.Android)
                jc.CallStatic("cancelCurrentSession");
        }

        public static bool GetMultiSessionRecord()
        {
            if (Application.platform == RuntimePlatform.Android)
                return jc.CallStatic<bool>("getMultiSessionRecord");
            return false;
        }

        public static void SetMultiSessionRecord(bool recordMultipleSession)
        {
            if (Application.platform == RuntimePlatform.Android)
                jc.CallStatic("setMultiSessionRecord", recordMultipleSession);
        }

        public static ulong PendingUploads()
        {
            if (Application.platform == RuntimePlatform.Android)
                return jc.CallStatic<ulong>("pendingUploads");
            return 0;
        }

        public static void DeletePendingUploads()
        {
            if (Application.platform == RuntimePlatform.Android)
                jc.CallStatic("deletePendingUploads");
        }

        /// <summary>
        /// IOS only
        /// </summary>
        public static void UploadPendingSession() {}

        /// <summary>
        /// IOS only. Gives callback when session upload completes on objectMethod. Note: Won't trigger if object not active/destroyed
        /// </summary>
        /// <param name="objectName">Name of the object currently active in scene</param>
        /// <param name="objectMethod">Method inside script attached to the object</param>
        public static void UploadPendingSessionCallback(string objectName, string objectMethod){}

        public static string UrlForCurrentSession()
        {
            if (Application.platform == RuntimePlatform.Android)
                return jc.CallStatic<string>("urlForCurrentSession");
            return "";
        }

        public static string UrlForCurrentUser()
        {
            if (Application.platform == RuntimePlatform.Android)
                return jc.CallStatic<string>("urlForCurrentUser");
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

            if (Application.platform == RuntimePlatform.Android)
                jw.CallStatic("logEvent", eventName, eventProperties);
        }

        /// <summary>
        /// For ios only. Not available for android
        /// </summary>
        /// <param name="disable"></param>
        public static void DisableCrashHanding(bool disable){ }
    }
}

#endif