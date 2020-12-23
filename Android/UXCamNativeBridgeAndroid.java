import com.unity3d.player.UnityPlayer;
import com.uxcam.OnVerificationListener;
import com.uxcam.UXCam;
import java.util.Map;
import java.util.HashMap;

public class UXCamNativeBridgeAndroid {
    public static void onVerificationListener(String gameObject, String gameMethod) {
        UXCam.addVerificationListener(new OnVerificationListener() {
            @Override
            public void onVerificationSuccess() {
                UnityPlayer.UnitySendMessage(gameObject, gameMethod, "true");
            }

            @Override
            public void onVerificationFailed(String s) {
                UnityPlayer.UnitySendMessage(gameObject, gameMethod, s);
            }
        });
    }

    public static void logEvent(String eventName, String properties){
        Map<String, String> mp = new HashMap<String, String>();
        mp.put("props", properties);
        UXCam.logEvent(eventName, mp);
    }

    public static void reportBugEvent(String eventName, String properties){
        Map<String, String> mp = new HashMap<String, String>();
        mp.put("props", properties);
        UXCam.reportBugEvent(eventName, mp);
    }
}
