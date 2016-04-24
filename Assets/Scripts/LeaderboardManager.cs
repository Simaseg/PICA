using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LeaderboardManager : MonoBehaviour {

    // singleton
    private static LeaderboardManager _instance;
    public static LeaderboardManager Instance {
        get {
            if (_instance == null) {
                _instance = GameObject.FindObjectOfType<LeaderboardManager>();
            }
            return LeaderboardManager._instance;
        }
    }

    public static string s_playerName;
    public static float s_level1time;
    public static float s_level2time;
    public static float s_endTime;

    public Text timeDisplay;

    [HideInInspector] public float timeGlobal;

    // singleton
    void Awake() {
        if (_instance == null) _instance = this;
        else {
            DestroyImmediate(this);
            return;
        }
    }

    void Update () {
		if (Application.loadedLevelName == "Level2") {
            s_level1time = Mathf.Round(Time.timeSinceLevelLoad);
        }

		if (Application.loadedLevelName == "Level1") {
            s_level2time = Mathf.Round(Time.timeSinceLevelLoad);
        }

        timeGlobal = s_level1time + s_level2time;

        if (timeGlobal >= 60f) {
            // converts the seconds into a minutes/seconds division
            timeDisplay.text = (Mathf.FloorToInt(timeGlobal / 60f)).ToString() + ":" + (timeGlobal % 60f).ToString();
        }
        else {
            // gives the value to the seconds area
            timeDisplay.text = "0:" + timeGlobal.ToString();
        }
    }
}
