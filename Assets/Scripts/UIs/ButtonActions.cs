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

    public void ClickShowAttendenceButton()
    {
        IngameManager.instance.AttendenceShowerOn();
    }

    public void ClickExitWindow()
    {
        IngameManager.instance.AttendenceShowerOff();
    }

    public void ClickInteractButton()
    {
        IngameManager.instance.ShowChatWnd();
    }

    public void ClickEndChatButton()
    {
        IngameManager.instance.CloseChatWnd();
    }
}
