using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameChangeWindow : MonoBehaviour
{
    public void NameChangeWndOn()
    {
        this.gameObject.SetActive(true);
    }
    public void NameChangeWndOff()
    {
        IngameManager.instance.ChangeName();
        this.gameObject.SetActive(false);
    }
}
