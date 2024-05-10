using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CharacterSelectWindow : MonoBehaviour
{
    [SerializeField] Image selectedCharacterApplyImage;
    Sprite selectedSprite;

    public void SetSelectedCharacter()
    {
        selectedSprite = EventSystem.current.currentSelectedGameObject.GetComponent<Image>().sprite;

        selectedCharacterApplyImage.sprite = selectedSprite;
        this.gameObject.SetActive(false);
    }

    public void ShowCharacterSelectWindow()
    {
        this.gameObject.SetActive(true);
    }
}
