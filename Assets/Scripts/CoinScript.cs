﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    //public AudioSource 10pointcoinsound;
    // Start is called before the first frame update

    
    private float coinrotation = 100;
    [SerializeField] GameObject fx;
    private GameObject go;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float angle = coinrotation * Time.deltaTime;
        transform.Rotate(Vector3.up * angle, Space.World);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Girl")
        {
            if(go != null)
            {
                return;
            }
            else
            {
                gameObject.GetComponent<MeshRenderer>().enabled = false;
                go = Instantiate(fx, transform);
                go.transform.SetParent(gameObject.transform);
               
            }
            Destroy(gameObject, 1f);
            
            
        }
        
       
    }

}
