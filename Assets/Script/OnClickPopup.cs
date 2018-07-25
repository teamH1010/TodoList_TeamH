using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnClickPopup : MonoBehaviour {

    public void LoadSetting()
    {
        GameObject.Find("Canvas").transform.Find("SettingPanel").gameObject.SetActive(true);
    }

    public void LoadCompleteSetting()
    {
        GameObject.Find("Canvas").transform.Find("CompletePanel").gameObject.SetActive(true);
    }

    public void LoadRemoveSetting()
    {
        GameObject.Find("Canvas").transform.Find("RemovePanel").gameObject.SetActive(true);
        this.Cancel();
    }


    public void Cancel()
    {
        GameObject.Find("SettingPanel").SetActive(false);
    }

    public void CompCancel()
    {
        GameObject.Find("CompletePanel").SetActive(false);
    }

    public void RemoveCancel()
    {
        GameObject.Find("RemovePanel").SetActive(false);
    }


    public void LoadUnderwater()
    {
        SceneManager.LoadScene("Underwater");
    }
}

