using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{    
    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    public void NextScene(string Game)
    {
        SceneManager.LoadScene(Game);
    }
   
    public void ChangeRes(Dropdown drop)
    {
        switch (drop.value)
        {
            case 0:
                Screen.SetResolution(1024, 768, true);
                break;
            case 1:
                Screen.SetResolution(1280, 720, true);
                break;

            case 2:
                Screen.SetResolution(1366, 768, true);
                break;
            case 3:
                Screen.SetResolution(1920, 1080, true);
                break;
        }
    }
    public void changeVolume(Slider slider)
    {

        AudioListener.volume = slider.value;
    }
    public void CloseApp()
    {
        Application.Quit();
    }
}
