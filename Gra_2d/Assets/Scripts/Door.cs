using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Door : Collectable
{

    public Sprite open_door;
    public int pesosAmount = 5;
    protected override void OnCollect()
    {

        if (!collected)
        {
            collected = true;
            GetComponent<SpriteRenderer>().sprite = open_door;
            Debug.Log("Grant + " + pesosAmount + "pesos!");
        }
    }
}