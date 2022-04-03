using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Welcomin : MonoBehaviour
{
    float timer;
    public GameObject ST;
    void Start()
    {
        ST.SetActive(false);
    }
    void Update()
    {
        // StartToClose(5);
        StartCoroutine(ClosePanel(5));
    }
    void StartToClose(float time)
    {
        timer += Time.deltaTime;
        if (timer >= time)
        {
            gameObject.SetActive(false);
            timer = 0;
        }
    }
    IEnumerator ClosePanel(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        ST.SetActive(true);
        gameObject.SetActive(false);
    }
}
