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
    public void SpawnPowerUp(float x , float y)
    {
        Instantiate(prefabs[UnityEngine.Random.Range(0, 1)], new Vector3(x, y, 0), Quaternion.identity);
    }
}

