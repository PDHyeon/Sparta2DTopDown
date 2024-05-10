using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameTag : MonoBehaviour
{
    Text nicknameTxt;

    void Awake()
    {
        nicknameTxt = GetComponentInChildren<Text>();

        nicknameTxt.text = PlayerPrefs.GetString("nickname");
    }
}
