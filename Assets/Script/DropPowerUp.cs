using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropPowerUp : MonoBehaviour
{
    SpriteRenderer spRend;
    public bool dropsPowerUp = false;
    private void Start()
    {
        if (dropsPowerUp == true)
        {
            spRend = GetComponent<SpriteRenderer>();
            spRend.color = Color.yellow;
        }
    }
    public void DropsPowerUp()
    {
        dropsPowerUp = true;
    }
}

