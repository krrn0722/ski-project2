using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NCMB;


public class SaveScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        NCMBObject obj = new NCMBObject ("ClearTime");
        obj["Name"] = UserPublicScript.userName;
        obj["Time"] = UserPublicScript.clearTime;
        obj.SaveAsync ((NCMBException e) => {      
        if (e != null) {
            Debug.Log("保存時エラー");
        } else {
            //成功時の処理
        }                   
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
