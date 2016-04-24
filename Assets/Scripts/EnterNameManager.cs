using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EnterNameManager : MonoBehaviour {

    [Header("Important Values")]
    
    // the visual text showing the name
    public Text nameDisplay;
    // the maximum number of characters the name can have
    public int maxLength = 5;
    
    [Header("Divers")]

    // the selected object when entering the scene
    public GameObject firstSelectedObject;

    private string _name;
    private int _actualLength = 0;

    void Start() {
        //EventSystem.current.SetSelectedGameObject(firstSelectedObject);
    }

    void Update() {
        Debug.Log(_actualLength);
    }

    /// <summary>
    /// updates the text value
    /// </summary>
	void UpdateName() {
        nameDisplay.text = _name;
    }

    /// <summary>
    /// BUTTON: adds a letter to the name
    /// updates the name
    /// </summary>
    public void AddLetter(string _letter) {
        if (_actualLength < maxLength) {
            _name = _name + _letter;

            _actualLength++;
        }

        UpdateName();
    }

    /// <summary>
    /// BUTTON: removes the last letter of the name
    /// updates the name
    /// </summary>
    public void RemoveLetter() {
        if (_actualLength > 0) {
            _name = _name.Remove(_name.Length - 1);

            _actualLength--;
        }

        UpdateName();
    }

    /// <summary>
    /// saves the name and loads the next scene
    /// </summary>
    public void Continue(string _sceneName) {
        LeaderboardManager.s_playerName = _name;

        Application.LoadLevel(_sceneName);
    }
}
