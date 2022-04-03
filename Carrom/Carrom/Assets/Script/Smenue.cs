using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smenue : MonoBehaviour
{
    // to show the start menue when the player press Enter button and ESC to exit from the star button
    public GameObject StartMenue;
    public GameObject ST;
    void Start()
    {
       // StartMenue.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            ST.SetActive(false);
            StartMenue.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ST.SetActive(true);
            StartMenue.SetActive(false);
        }
    }
}
