using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goal : MonoBehaviour
{
// 当たり判定
void OnCollisionEnter(Collision collision)
{
    SceneManager.LoadScene("RankingScene");
      Debug.Log("Hit"); // ログを表示する
}

    
}