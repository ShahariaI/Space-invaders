using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DropPowerUp : MonoBehaviour
{
    SpriteRenderer spRend;
    public GameObject[] prefabs;

    private void Start()
    {
        prefabs = Resources.LoadAll<GameObject>("PowerUp_prefabs");

        spRend = GetComponent<SpriteRenderer>();
        spRend.color = Color.yellow;

        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if 
        Instantiate(prefabs[0]);
    }
}

