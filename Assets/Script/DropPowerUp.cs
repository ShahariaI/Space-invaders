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
    public void SpawnPowerUp()
    {
        Instantiate(prefabs[UnityEngine.Random.Range(1, 2)]);
    }
}

