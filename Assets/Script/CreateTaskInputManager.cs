using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateTaskInputManager : MonoBehaviour {

    InputField titlefiled = null;
    InputField detailfiled = null;
    InputField datefield = null;
    InputField timefiled = null;

    /// <summary>
    /// Startメソッド
    /// InputFieldコンポーネントの取得および初期化メソッドの実行
    /// </summary>

    void Start()
    {
        var inputtitle = GameObject.Find("InputTitle");
        var inputdate = GameObject.Find("InputDate");
        var inputtime = GameObject.Find("InputTime");
        var inputdetail = GameObject.Find("InputDetail");

        titlefiled = inputtitle.GetComponent<InputField>();
        datefield = inputdate.GetComponent<InputField>();
        timefiled = inputtime.GetComponent<InputField>();
        detailfiled = inputdetail.GetComponent<InputField>();

        // 値をリセット
        titlefiled.text = "";
        datefield.text = "";
        timefiled.text = "";
        detailfiled.text = "";

        // フォーカス
        titlefiled.ActivateInputField();
        datefield.ActivateInputField();
        timefiled.ActivateInputField();
        detailfiled.ActivateInputField();

    }

    /// <summary>
    /// Log出力用メソッド
    /// 入力値を取得してLogに出力し、初期化
    /// </summary>

    public void InputLogger()
    {

        Debug.Log(this.titlefiled.text);
        Debug.Log(this.datefield.text);
        Debug.Log(this.timefiled.text);
        Debug.Log(this.detailfiled.text);

        //SQLite insert文実行
    }

}
