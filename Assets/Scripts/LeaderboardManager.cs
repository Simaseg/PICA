using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LeaderboardManager : MonoBehaviour {

    public static string s_playerName;
    public static float s_level1time;
    public static float s_level2time;

    public Text timeDisplay;

    private float timeGlobal;
	
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
