using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Blue_Chest : Collectable
{

    public Sprite chest_2;
    public int pesosAmount = 5;
    protected override void OnCollect()
    {

        if (!collected)
        {
            collected = true;
            GetComponent<SpriteRenderer>().sprite = chest_2;
            GameManager.instance.ShowText("+" + pesosAmount + " pesos!", 25, Color.yellow, transform.position, Vector3.up * 50, 1.5f);
        }
    }
}