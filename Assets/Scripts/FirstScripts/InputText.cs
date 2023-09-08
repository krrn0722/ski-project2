using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputText : MonoBehaviour
{
    //オブジェクトと結びつける
    public TMP_InputField inputField;
    // public Text text;
    public static string tmpUserName;

    void Start () {
        //Componentを扱えるようにする
        inputField = inputField.GetComponent<TMP_InputField> ();
        // text = text.GetComponent<Text> ();
    }

    // public void InputTextChanged(){
    //     //テキストにinputFieldの内容を反映
    //     text.text = inputField.text;
    // }
    public void InputTextEditEnd(){
        //テキストインプットの内容をユーザーネームとして保存する
        UserPublicScript.userName = inputField.text;
     }
}
