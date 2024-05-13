using DefineHelper;
using System.Collections.Generic;
using UnityEngine;

public class IngameManager : MonoBehaviour
{
    public static IngameManager instance;

    [SerializeField] GameObject[] characters;
    [SerializeField] GameObject nameChangeWnd;

    GameObject nowPlayingCharacter;
    NameTag nameTag;

    public List<string> attendanceList = new List<string>();
    [SerializeField]AttendanceShower attendanceShower;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    private void Start()
    {
        InitializeSet();
    }

    public void ChangeCharacterIngame()
    {
        GameManager.instance.characterPos = nowPlayingCharacter.transform.position;

        SceneControlManager.instance.LoadScene(eSceneType.Ingame);
    }

    public void SetPlayerInfo()
    {
        nowPlayingCharacter = Instantiate(characters[PlayerPrefs.GetInt("CharacterType")]);
        nowPlayingCharacter.transform.position = GameManager.instance.characterPos;
    }

    public void ChangeNameWndOn()
    {
        nameChangeWnd.GetComponent<NameChangeWindow>().NameChangeWndOn();
    }

    public void ApplyNameToNameTag()
    {
        nowPlayingCharacter.GetComponentInChildren<NameTag>().SetName();
        ApplyNameToAttendenceList();
    }
    public void ApplyNameToAttendenceList()
    {
        attendanceShower.ChangePlayerName(PlayerPrefs.GetString("Nickname"));
    }

    public void InitializeSet()
    {
        SetPlayerInfo();
        attendanceList.Add(PlayerPrefs.GetString("Nickname"));
        attendanceList.Add("Manager1");
        attendanceShower.ShowAllAttendance();
        ApplyNameToNameTag();       
    }

    public void AttendenceShowerOn()
    {
        attendanceShower.transform.parent.gameObject.SetActive(true);
    }

    public void AttendenceShowerOff()
    {
        attendanceShower.transform.parent.gameObject.SetActive(false);
    }
}
