﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadTestTaskList : MonoBehaviour {

    /// ボタンをクリックした時の処理
    public void OnClick()
    {
        Debug.Log("Button click!");
        SceneManager.LoadScene("TestTaskList");
    }

}
