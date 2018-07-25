using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PanelController : MonoBehaviour {

    [SerializeField]
    RectTransform prefab = null;

    void Start()
    {
        GameObject.Find("CompletePanel").SetActive(false);

        for (int i = 0; i < 2; i++)
        {
            var item = GameObject.Instantiate(prefab) as RectTransform;
            item.SetParent(transform, false);

            var text = item.GetComponentInChildren<Text>();
            text.text = "item:" + i.ToString();
        }
    }
}
