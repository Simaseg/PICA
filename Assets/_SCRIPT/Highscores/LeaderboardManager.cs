﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LeaderboardManager : MonoBehaviour {

    public static string s_playerName;
    public static float timeGlobal;
    public static float s_level1time;
    public static float s_level2time;

    public Text timeDisplay;

	void Update () {
        if (SceneManager.GetActiveScene().name == "Level2") {
            s_level1time = Mathf.Round(Time.timeSinceLevelLoad);
        }

        if (SceneManager.GetActiveScene().name == "Level1") {
            s_level2time = Mathf.Round(Time.timeSinceLevelLoad);
        }
        
        timeGlobal = s_level1time + s_level2time;

        if (timeGlobal >= 60f) {
            // converts the seconds into a minutes/seconds division
            timeDisplay.text = (Mathf.FloorToInt(timeGlobal / 60f)).ToString() + " min" + (timeGlobal % 60f).ToString() + "sec";
        }
        else {
            // gives the value to the seconds area
            timeDisplay.text = timeGlobal.ToString() + " sec";
        }
    }
}
