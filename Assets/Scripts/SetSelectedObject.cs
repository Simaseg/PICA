using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class SetSelectedObject : MonoBehaviour {

    public GameObject initialSelectedObject;

    void Start() {
        //EventSystem.current.SetSelectedGameObject(initialSelectedObject);
    }
}
