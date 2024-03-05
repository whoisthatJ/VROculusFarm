using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boy_Scenario_2 : MonoBehaviour
{
    public AudioClip Hello_1;
    public AudioClip name_2;
    public AudioClip how_old_3;
    public AudioClip aidos_4;
    public AudioClip Howareyou_5;
    public AudioClip Nastroy_6;
    public AudioClip Like_animals_7;
    public AudioClip Animals_see_8;
    public AudioClip Who_walk_9;
    public AudioClip Correct_10;
    public AudioClip see_horse_11;
    public AudioClip come_closer_12;
    public AudioClip like_horse_13;
    public AudioClip good_bye_14;


    AudioSource Real_Boy_audio;
    Animator Real_boy_anim;

    // Start is called before the first frame update
    void Start()
    {
        Real_Boy_audio = GetComponent<AudioSource>();
        Real_boy_anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Real_boy_anim.Play("hello1");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Real_boy_anim.Play("Tell_me_about_yourself_2");
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Real_boy_anim.Play("Dog_task_3");
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Real_boy_anim.Play("Dog_likes_you_4");
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            Real_boy_anim.Play("Apple_task_5");
        }

    }

    void hi_Play()
    {
        Real_Boy_audio.PlayOneShot(Hello_1);
    }
    void name_Play()
    {
        Real_Boy_audio.PlayOneShot(name_2);
    }
    void Old_play()
    {
        Real_Boy_audio.PlayOneShot(how_old_3);
    }
    void aidos_Play()
    {
        Real_Boy_audio.PlayOneShot(aidos_4);
    }
    void howareyou_play()
    {
        Real_Boy_audio.PlayOneShot(Howareyou_5);
    }
    void nastroy_play()
    {
        Real_Boy_audio.PlayOneShot(Nastroy_6);
    }

    void like_animals_play()
    {
        Real_Boy_audio.PlayOneShot(Like_animals_7);
    }
    void animals_see_play()
    {
        Real_Boy_audio.PlayOneShot(Animals_see_8);
    }
    void who_walk_play()
    {
        Real_Boy_audio.PlayOneShot(Who_walk_9);
    }

    void correct_play()
    {
        Real_Boy_audio.PlayOneShot(Correct_10);
    }

    void see_horse_play()
    {
        Real_Boy_audio.PlayOneShot(see_horse_11);
    }
    void come_closer_play()
    {
        Real_Boy_audio.PlayOneShot(come_closer_12);
    }
    void like_horse_play()
    {
        Real_Boy_audio.PlayOneShot(like_horse_13);
    }
    public void goodbye_play()
    {
        Real_Boy_audio.PlayOneShot(good_bye_14);
    }
}
