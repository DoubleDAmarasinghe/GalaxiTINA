using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public AudioSource hwrclip;
    public AudioSource clkclip;
    public Slider sliderrr;
    public void playgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void quitgame()
    {
        Debug.Log("hhhhh");
        Application.Quit();
    }

    public void Hoversound()
    {
        hwrclip.Play();
    }

    public void Clicksound()
    {
        clkclip.Play();
    }

    public void slidervalue()
    {
        Debug.Log(sliderrr.value);
    }
}
