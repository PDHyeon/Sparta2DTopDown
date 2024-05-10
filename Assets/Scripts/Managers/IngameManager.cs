using UnityEngine;

public class IngameManager : MonoBehaviour
{
    [SerializeField] GameObject[] characters;

    private void Start()
    {
        InitializeSet();
    }
    public void SetPlayerInfo()
    {
        GameObject go = Instantiate(characters[PlayerPrefs.GetInt("CharacterType")]);
    }
    public void InitializeSet()
    {
        SetPlayerInfo();
    }
}
