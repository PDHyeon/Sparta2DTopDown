using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DefineHelper;

public class StartButton : MonoBehaviour
{
    public InputField nicknameInputField;

    public void JoinGamewithNickName()
    {
        if(nicknameInputField.text.Length >= 2 && nicknameInputField.text.Length < 10)
        {
            PlayerPrefs.SetString("Nickname", nicknameInputField.text);

            // 스타트 씬일때만 인게임 불러오기
            if (GameManager.instance.nowSceneType == eSceneType.Start)
            {
                SceneControlManager.instance.LoadScene(DefineHelper.eSceneType.Ingame);
            }
        }
    }
}
