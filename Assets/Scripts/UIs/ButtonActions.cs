using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActions : MonoBehaviour
{
    public void ClickCharacterSelectButton()
    {
        GameManager.instance.ShowCharacterSelectWnd();
    }

    public void ClickChangeNameButton()
    {
        IngameManager.instance.ChangeNameWndOn();
    }

    public void ClickChangeCharacterButton()
    {
        
    }
}
