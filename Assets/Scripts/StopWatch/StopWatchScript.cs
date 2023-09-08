using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopWatchScriot : MonoBehaviour
{

    
    public static float countTime = 0;

    // Use this for initialization
    void Start()
    {
        countTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // countTimeに、ゲームが開始してからの秒数を格納
        countTime += Time.deltaTime;

        // 小数2桁にして表示
        GetComponent<Text>().text = countTime.ToString("F5");
    }

    void PushButton(){
        
    }
}
