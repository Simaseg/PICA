using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SaveScores : MonoBehaviour {

    private string _saveScoreUrl = "http://e.menegazzi.free.fr/Pica_01/SaveScore.php?";

    IEnumerator SaveScore(string name, float score) {
        string post_url = _saveScoreUrl + "name=" + WWW.EscapeURL(name) + "&score=" + score;

        // Post the URL to the site and create a download object to get the result.
        WWW hs_post = new WWW(post_url);
        yield return hs_post; // Wait until the download is done

        if (hs_post.error != null) {
            print("There was an error posting the high score: " + hs_post.error);
            Debug.Log("done");
        }

        Application.LoadLevel("Bravo");
    }

    public void Save() {
        LeaderboardManager.s_endTime = LeaderboardManager.Instance.timeGlobal;
        LeaderboardManager.Instance.timeGlobal = 0f;
        StartCoroutine(SaveScore(LeaderboardManager.s_playerName, LeaderboardManager.s_endTime));
    }
}
