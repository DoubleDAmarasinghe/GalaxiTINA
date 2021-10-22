using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EtoOpen : MonoBehaviour
{
    public Text text;
    


    void Start()
    {
        text.enabled = false;
    }

    void Update()
    {
        //test();
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.name == "Girl")
        {

            text.enabled = true;

        }
    }
         void OnTriggerExit(Collider other)
        {

          

                text.enabled = false;

            


        }
  

}
