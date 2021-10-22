using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{

    public AudioSource audiosourxe;
    public float musicvolume = 1f;


    // Start is called before the first frame update
    void Start()
    {
        audiosourxe.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        audiosourxe.volume = musicvolume;
    }

    public void updatevolume(float volume)
    {
        musicvolume = volume;
    }
}
