using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class CharacterSelectWindow : MonoBehaviour
{
    [SerializeField] Image selectedCharacterApplyImage;
    Sprite selectedSprite;

    public void SetSelectedCharacter(int characterIdx)
    {
        selectedSprite = EventSystem.current.currentSelectedGameObject.GetComponent<Image>().sprite;

        selectedCharacterApplyImage.sprite = selectedSprite;
        PlayerPrefs.SetInt("CharacterType", characterIdx);
        this.gameObject.SetActive(false);
    }

    public void ShowCharacterSelectWindow()
    {
        this.gameObject.SetActive(true);
    }
}
