using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cow_moo : MonoBehaviour
{

    AudioSource cow_audio;

    void Start()
    {
        cow_audio=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Moo()
    {
        cow_audio.Play();

    }
}
