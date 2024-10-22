using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Showlife : MonoBehaviour
{
    public int livesNeededToShow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (FindAnyObjectByType<Player>().Lives >= livesNeededToShow)
        {
            GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        {
            GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
