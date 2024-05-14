using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCBehavior : MonoBehaviour
{
    public GameObject interactWnd;
    public GameObject chatWnd;

    public void ShowInteractWindowOn()
    {
        interactWnd.SetActive(true);
    }

    public void ShowInteractWindowOff()
    {
        interactWnd.SetActive(false);
    }

    public void ShowChatWindowOn()
    {
        chatWnd.SetActive(true);
    }
    
    public void ShowChatWindowOff()
    {
        chatWnd.SetActive(false);
    }
}

