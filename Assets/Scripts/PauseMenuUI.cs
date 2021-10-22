using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PauseMenuFinal : MonoBehaviour
{
    public static bool gameispaused = false;
    //public GameObject pausemenuui;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
      
    }

  

    
    public void Mainmenu()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        SceneManager.LoadScene("MainMenu");
    }

   
}
