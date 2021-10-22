using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToLevelTwo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Restartlevel02()
    {
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("SecondLevel");

    }
}
