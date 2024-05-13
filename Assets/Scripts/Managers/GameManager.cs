using UnityEngine;
using UnityEngine.SceneManagement;
using DefineHelper;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] GameObject characterSelectWnd;
    [SerializeField] Image oriCharacterImage;

    public eSceneType nowSceneType;

    public Vector2 characterPos;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }

        nowSceneType = eSceneType.Start;
        // 최초 시작 시에는 남자 캐릭터로 설정
        PlayerPrefs.SetInt("CharacterType", (int)eCharacterType.Boy);
    }

    public void ShowCharacterSelectWnd()
    {
        GameObject go = Instantiate(characterSelectWnd, GameObject.FindGameObjectWithTag("UI").transform);
        
        RectTransform rectTransform = go.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = Vector3.zero;

        Time.timeScale = 0f;
    }

    public void ChangeCharacter(Sprite s)
    {
        switch(nowSceneType)
        {
            case eSceneType.Start:
                oriCharacterImage.sprite = s;
                break;
            case eSceneType.Ingame:
                IngameManager.instance.ChangeCharacterIngame();
                break;
        }
    }
}
