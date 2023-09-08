using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StatrButton : MonoBehaviour
{
    // ボタンが押された時、名前を保存、ゲームスタート
    public void OnClickGameStart()
    {
       SceneManager.LoadSceneAsync("sample2");
    }
}
