using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChange : MonoBehaviour {

    public Text text;
    int i = 0;

    // Use this for initialization
    void Start () {
        string inputtext = "ConoHa2メンテ";
        text.text = inputtext;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
