using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameOver : MonoBehaviour
{
    public Text pointsText;


   public void Setup(int score)
    {
        

        pointsText.text = score.ToString() + " Points";
    }



}
