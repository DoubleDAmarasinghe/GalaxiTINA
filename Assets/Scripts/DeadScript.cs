using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Girl")
        {
           
                SceneManager.LoadScene("GameOver");
            
        }


    }
}
