using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("CreateTask");
        }
    }
}

//これがそちらから見えていればOK
//青木：新しくブランチを作ってから名前と適当なコメントをつけてPush
//してみてね↓