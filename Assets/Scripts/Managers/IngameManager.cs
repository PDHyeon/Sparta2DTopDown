using DefineHelper;
using UnityEngine;

public class IngameManager : MonoBehaviour
{
    public static IngameManager instance;

    [SerializeField] GameObject[] characters;
    GameObject nowPlayingCharacter;

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
    public void InitializeSet()
    {
        SetPlayerInfo();
    }
}
