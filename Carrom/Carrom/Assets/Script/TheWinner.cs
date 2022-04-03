using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TheWinner : MonoBehaviour
{
    //to controll the winner panel
   public RightMouse Winner;
    public Text winner;
    public int number;
    public int ps;
    void Update()
    {
        if (Winner.i >= 19)
        {
            gameObject.SetActive(true);
            winner.text = "The winner is \n " + "P" + Winner.WinnerPn + "\n" + Winner.WinnerPoints + "Points";
        }
    }
}
