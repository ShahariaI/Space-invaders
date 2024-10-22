using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLives : MonoBehaviour
{

    public int Lives = 3;
    public Image[] LivesUI;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.gameObject.tag == "Missile")
        {

            Destroy(collision.collider.gameObject);
            Lives -= 1;

            for(int i =0; i < LivesUI.Length; i++)
            {
                if( Lives <= 0)
                {
                    LivesUI[i].enabled = true;
                }
                else
                {
                    LivesUI[i].enabled = false;
                }

            }
           if(Lives <= 0)
            {
                Destroy(gameObject);


            
           }

        } 
    }



}
