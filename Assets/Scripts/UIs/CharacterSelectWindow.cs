using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class CharacterSelectWindow : MonoBehaviour
{
    Sprite selectedSprite;

    public void SetSelectedCharacter(int characterIdx)
    {
        selectedSprite = EventSystem.current.currentSelectedGameObject.GetComponent<Image>().sprite;

        GameManager.instance.ChangeCharacter(selectedSprite);
        
        PlayerPrefs.SetInt("CharacterType", characterIdx);

        Time.timeScale = 1.0f;
        Destroy(gameObject);
    }
}
