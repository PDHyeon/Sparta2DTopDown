using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public InputField nicknameInputField;

    public void JoinGamewithNickName()
    {
        if(nicknameInputField.text.Length >= 2 && nicknameInputField.text.Length < 10)
        {
            PlayerPrefs.SetString("Nickname", nicknameInputField.text);
            SceneControlManager.instance.LoadScene(DefineHelper.eSceneType.Ingame);
        }
    }
}
