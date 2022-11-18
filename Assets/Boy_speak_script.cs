using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boy_speak_script : MonoBehaviour
{
    public AudioClip hello;
    public AudioClip howOldAreYou;
    public AudioClip WhatIsYourName;
    public AudioClip willYouPlay;

    public AudioClip lets_play;
    public AudioClip ready;
    public AudioClip onemore;
    public AudioClip scissors_onemore;
    public AudioClip paper_onemore;
    public AudioClip rock;
    public AudioClip you_win;
    public AudioClip i_win_audio;

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
      
        if (Input.GetKeyDown(KeyCode.Y))
        {
            boy_anim.Play("i_win");
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
    void letsplay()
    {
        Boy_audio.PlayOneShot(lets_play);
    }
    void readyPlay()
    {
        Boy_audio.PlayOneShot(ready);
    }

    void scissors_play()
    {
        Boy_audio.PlayOneShot(scissors_onemore);
    }
    void paper_play()
    {
        Boy_audio.PlayOneShot(paper_onemore);
    }
    void rock_play()
    {
        Boy_audio.PlayOneShot(rock);
    }

    void you_win_play()
    {
        Boy_audio.PlayOneShot(you_win);
    }
    void i_win_play()
    {
        Boy_audio.PlayOneShot(i_win_audio);
    }
    void onemore_play()
    {
        Boy_audio.PlayOneShot(onemore);
    }
}
