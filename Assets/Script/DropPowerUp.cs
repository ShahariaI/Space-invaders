using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DropPowerUp : MonoBehaviour
{
    SpriteRenderer spRend;
    public PowerUp[] prefab = new PowerUp[1];

    private void Start()
    {
        spRend = GetComponent<SpriteRenderer>();
        spRend.color = Color.yellow;

        
    }
    private void OnDestroy()
    {
       
        prefab = Resources.Load("prefabs/prefab1", PowerUp) as GameObject;
        Instantiate(prefab[0], transform);
    }
}

