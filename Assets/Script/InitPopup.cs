using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitPopup : MonoBehaviour {

    void Start()
    {
        GameObject.Find("SettingPanel").SetActive(false);
        GameObject.Find("CompletePanel").SetActive(false);
        GameObject.Find("RemovePanel").SetActive(false);
    }

}
