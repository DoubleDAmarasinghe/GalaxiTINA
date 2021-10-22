using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Restartlevel01 : MonoBehaviour
{

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    public void Restartlevel()
    {
        SceneManager.LoadScene("FirstLevel");
        
    }

    public void Restartlevel02()
    {
        SceneManager.LoadScene("SecondLevel");

    }
}
