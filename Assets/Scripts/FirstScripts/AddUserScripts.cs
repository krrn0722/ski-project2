using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NCMB;

public class AddUserScripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void resistUser() 
    {
        NCMBObject obj = new NCMBObject ("User");
        obj.Add ("name", "time");
        obj.SaveAsync ((NCMBException e) => {      
            if (e != null) {
                //エラー処理
            } else {
                //成功時の処理
            }                   
        });
    }
        
}
