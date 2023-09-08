using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndRetryButton : MonoBehaviour
{
    public void OnClickGameRetry()
    {
       SceneManager.LoadSceneAsync("SampleScene");
    }

    public void OnClickGameEnd()
    {
       SceneManager.LoadSceneAsync("FirstScene");
    }
}
