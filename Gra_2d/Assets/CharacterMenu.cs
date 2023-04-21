using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;
using UnityEngine.UI;

public class CharacterMenu : MonoBehaviour
{
    //Text fields
    public Text levelText, hitpointText, pesosText, upgradeCostText, xpText;

    //Logic
    private int currentCharacterSelection = 0;
    public Image characterSelectionSprite;
    public Image weaponSprite;
    public RectTransform xpBar;

    // Chatacter Selection

    public void OnarrowClick(bool right)
    {
        if (right)
        {
            currentCharacterSelection++;

            //If we went too far away

            if (currentCharacterSelection  == GameManager.instance.playerSprites.Count)
                currentCharacterSelection = 0;

            OnSelectionChanged();
        }
        else

            currentCharacterSelection--;

        //If we went too far away

        if (currentCharacterSelection < 0 )
            currentCharacterSelection = GameManager.instance.playerSprites.Count - 1;

        OnSelectionChanged();
    }

    private void OnSelectionChanged()
    {
        characterSelectionSprite.sprite = GameManager.instance.playerSprites[currentCharacterSelection];    
    }

    // Weapon Upgrde
    public void OnUpgradeClick()
    {
        if(GameManager.instance.TryUpgradeWeapon())
            UpdateMenu();
    }

    //Upgrade the chatacter Infromation
    public void UpdateMenu()
    {
        //Weapon
        weaponSprite.sprite = GameManager.instance.weaponSprites[GameManager.instance.weapon.weaponLevel];
        upgradeCostText.text = "NOT IMPLEMENTED";


        // Meta
        levelText.text = "NOT IMPLEMENTED";
        hitpointText.text = GameManager.instance.player.hitpoint.ToString();
        pesosText.text = GameManager.instance.pesos.ToString();

        // xp Bar
        xpText.text = "NO IMPLEMENDTED";
        xpBar.localScale = new Vector3(0.5f, 0, 0);
    }
}

