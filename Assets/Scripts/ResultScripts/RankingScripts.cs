using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using NCMB;
using System.Linq;

// namespace NCMB
// {
public class RankingScripts : MonoBehaviour
  {
    public TextMeshProUGUI firstNameText;
    public TextMeshProUGUI firstTimeText;
    public    TextMeshProUGUI secondNameText;
    public TextMeshProUGUI secondTimeText;
    public TextMeshProUGUI thirdNameText;
    public TextMeshProUGUI thirdTimeText;

    // サーバーからランキングを取得  -----------------
    void Start()
    {

        // データストアの「ClearTime」クラスから、Nameをキーにして検索
        NCMBQuery<NCMBObject> query = new NCMBQuery<NCMBObject> ("ClearTime");

        query.OrderByAscending("Time");
        query.Limit = 3;
        //データストアでの検索を行う
        query.FindAsync ((List<NCMBObject> objList ,NCMBException e) => {
            if (e != null) {
                //検索失敗時の処理
            } else {
                //検索成功時の処理
                Debug.Log(objList.Count());
                switch (objList.Count()){
                    case 0:
                        break;
                    case 1:
                        firstNameText.text = objList[0]["Name"].ToString();
                        firstTimeText.text = objList[0]["Time"].ToString();
                        break;
                    case 2:
                        firstNameText.text = objList[0]["Name"].ToString();
                        firstTimeText.text = objList[0]["Time"].ToString();
                        secondNameText.text = objList[1]["Name"].ToString();
                        secondTimeText.text = objList[1]["Time"].ToString();
                        break;
                    default:
                        firstNameText.text = objList[0]["Name"].ToString();
                        firstTimeText.text = objList[0]["Time"].ToString() + "秒";
                        secondNameText.text = objList[1]["Name"].ToString();
                        secondTimeText.text = objList[1]["Time"].ToString() + "秒";
                        thirdNameText.text = objList[2]["Name"].ToString();
                        thirdTimeText.text = objList[2]["Time"].ToString() + "秒";     
                        break;
                }
            }
        });

    }
}
// }