using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog_script : MonoBehaviour
{
    AudioSource dog_audio;
    // Start is called before the first frame update
    void Start()
    {
        dog_audio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void dog_sniffing()
    {
        dog_audio.Play();

    }
}
