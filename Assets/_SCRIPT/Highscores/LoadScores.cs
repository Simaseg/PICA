using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class LoadScores : MonoBehaviour {

    public List<Text> v_names, v_scoresMin, v_scoresSec;

    private string _loadScoreUrl = "http://e.menegazzi.free.fr/Pica_01/LoadScore.php?";
    private string _words;
    private string[] _wordsSplitted;

    void Start() {
        Load();
    }

    IEnumerator LoadScore() {
        WWW hs_get = new WWW(_loadScoreUrl);
        yield return hs_get;

        if (hs_get.error != null) {
            print("There was an error getting the high score: " + hs_get.error);
        }
        else {
            _words = hs_get.text;
            _wordsSplitted = _words.Split(";"[0]);

            #region v_names writting
            v_names[0].text = _wordsSplitted[0];
            v_names[1].text = _wordsSplitted[2];
            v_names[2].text = _wordsSplitted[4];
            v_names[3].text = _wordsSplitted[6];
            v_names[4].text = _wordsSplitted[8];
            v_names[5].text = _wordsSplitted[10];
            v_names[6].text = _wordsSplitted[12];
            v_names[7].text = _wordsSplitted[14];
            v_names[8].text = _wordsSplitted[16];
            v_names[9].text = _wordsSplitted[18];
            #endregion

            #region v_scores writting
            ChargeLoadText(0);
            ChargeLoadText(1);
            ChargeLoadText(2);
            ChargeLoadText(3);
            ChargeLoadText(4);
            ChargeLoadText(5);
            ChargeLoadText(6);
            ChargeLoadText(7);
            ChargeLoadText(8);
            ChargeLoadText(9);
            #endregion
        }
    }

    /// <summary>
    /// loads the time and splits it into minutes and seconds if necessary
    /// </summary>
    void ChargeLoadText(int _id) {
        if (float.Parse(_wordsSplitted[(_id*2) + 1]) >= 60f) {
            // enables the text zones
            v_scoresMin[_id].enabled = true;
            v_scoresSec[_id].enabled = true;
            // converts the seconds into a minutes/seconds division
            v_scoresMin[_id].text = (Mathf.FloorToInt(float.Parse(_wordsSplitted[(_id * 2) + 1]) / 60f)).ToString() + " min";
            v_scoresSec[_id].text = (float.Parse(_wordsSplitted[(_id * 2) + 1]) % 60f).ToString() + " sec";
        }
        else {
            // disables the minutes text zone since it is not useful
            v_scoresMin[_id].enabled = false;
            // gives the value to the seconds area
            v_scoresSec[_id].text = float.Parse(_wordsSplitted[(_id * 2) + 1]).ToString() + " sec";
        }
    }

    /// <summary>
    /// loads the online score
    /// </summary>
    public void Load() {
        StartCoroutine(LoadScore());
    }
}
