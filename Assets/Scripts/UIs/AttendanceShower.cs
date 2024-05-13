using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttendanceShower : MonoBehaviour
{
    public Font font;
    RectTransform rt;
    List<Text> nameList = new List<Text>();

    private void Awake()
    {
        rt = this.transform.GetComponent<RectTransform>();
    }
    public void ShowAllAttendance()
    {
        foreach(string s in IngameManager.instance.attendanceList)
        {
            GameObject go = new GameObject("nameTxt");
            go.AddComponent<Text>();

            Text nameTxt = go.GetComponent<Text>();

            FontSet(nameTxt);
            nameTxt.text = s;

            go.transform.SetParent(rt);

            nameList.Add(nameTxt);
        }
    }

    public void FontSet(Text txt)
    {
        txt.font = font;
        txt.fontSize = 20;
        txt.alignment = TextAnchor.MiddleLeft;
        txt.rectTransform.sizeDelta = new Vector2(200f, 30f);
    }

    public void ChangePlayerName(string text)
    {
        nameList[0].text = text;
    }

    public void AddUser()
    {

    }
}
