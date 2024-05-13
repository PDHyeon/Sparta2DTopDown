using UnityEngine;
using UnityEngine.UI;

public class NameTag : MonoBehaviour
{
    Text nicknameTxt;

    private void Awake()
    {
        nicknameTxt = GetComponentInChildren<Text>();
    }

    public void SetName()
    {      
        nicknameTxt.text = PlayerPrefs.GetString("Nickname");
    }
}
