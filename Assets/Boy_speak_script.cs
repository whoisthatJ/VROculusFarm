using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boy_speak_script : MonoBehaviour
{
    public AudioClip hello;
    public AudioClip howOldAreYou;
    public AudioClip WhatIsYourName;
    public AudioClip willYouPlay;
    public AudioClip LookAtCow;
    AudioSource Boy_audio;
    Animator boy_anim;

    // Start is called before the first frame update
    void Start()
    {
        Boy_audio = GetComponent<AudioSource>();
        boy_anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) {
            boy_anim.Play("Boy_hello");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            boy_anim.Play("Boy_askingName");
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            boy_anim.Play("Boy_askingAge");
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            boy_anim.Play("Boy_willYouPlay");
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            boy_anim.Play("Boy_lookAtCow");
        }
      
    }

    void helloBoy()
    {
        Boy_audio.PlayOneShot(hello);
    }
    void agePlay()
    {
        Boy_audio.PlayOneShot(howOldAreYou);
    }
    void namePlay()
    {
        Boy_audio.PlayOneShot(WhatIsYourName);
    }
    void willPlay()
    {
        Boy_audio.PlayOneShot(willYouPlay);
    }
    void CowPlay()
    {
        Boy_audio.PlayOneShot(LookAtCow);
    }
}
