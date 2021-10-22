using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PauseMenuUI : MonoBehaviour
{
    public static bool gameispaused = false;
    public GameObject pausemenuui;
    // Start is called before the first frame update
    void Start()
    {
        Resume();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameispaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

    }

    public void Resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        pausemenuui.SetActive(false);
        Time.timeScale = 1f;
        gameispaused = false;

    }

    public void Pause()
    {
        Cursor.lockState = CursorLockMode.None;
        pausemenuui.SetActive(true);
        Time.timeScale = 0f;
        gameispaused = true;

    }
    public void Mainmenu()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        SceneManager.LoadScene("MainMenu");
    }

    public void Restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Cursor.lockState = CursorLockMode.Locked;
        pausemenuui.SetActive(false);
        Time.timeScale = 1f;
        gameispaused = false;

    }
    
    public void Restartlevel01()
    {
        SceneManager.LoadScene("FirstLevel");
        
    }
}
