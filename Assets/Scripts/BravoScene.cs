using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BravoScene : MonoBehaviour {

    public Text timer;

	void Start () {
        if (LeaderboardManager.s_endTime >= 60f) {
            // converts the seconds into a minutes/seconds division
            timer.text = (Mathf.FloorToInt(LeaderboardManager.s_endTime / 60f)).ToString() + ":" + (LeaderboardManager.s_endTime % 60f).ToString();
        }
        else {
            // gives the value to the seconds area
            timer.text = "0:" + LeaderboardManager.s_endTime.ToString();
        }
    }
}
