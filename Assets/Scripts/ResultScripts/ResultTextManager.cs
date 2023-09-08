using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ResultTextManager : MonoBehaviour
{
    public TextMeshProUGUI myNameText;
    public TextMeshProUGUI myTimeText; 

    void Start()
    {
        //ユーザー名
        // オブジェクトからTextコンポーネントを取得
        // テキストの表示を入れ替える
        myNameText.text = UserPublicScript.userName + "のタイム";

        //クリアタイム
        myTimeText.text =  UserPublicScript.clearTime.ToString("F5") + "秒";

    }
}
