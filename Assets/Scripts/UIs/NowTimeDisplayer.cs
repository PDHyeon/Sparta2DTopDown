using System;
using UnityEngine;
using UnityEngine.UI;

public class NowTimeDisplayer : MonoBehaviour
{
    Text timeTxt;

    private void Start()
    {
        timeTxt = GetComponentInChildren<Text>();
    }

    private void Update()
    {
        DateTime now = DateTime.Now;

        timeTxt.text = $"{now.Hour.ToString()}:{now.Minute.ToString()}";
    }
}
