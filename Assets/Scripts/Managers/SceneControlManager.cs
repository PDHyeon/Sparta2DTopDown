using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DefineHelper;
using UnityEngine.SceneManagement;

public class SceneControlManager : MonoBehaviour
{
    public static SceneControlManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    public void LoadScene(eSceneType sceneType)
    {
        SceneManager.LoadScene((int)sceneType);
        GameManager.instance.nowSceneType = DefineHelper.eSceneType.Ingame;
    }
}
