using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Real_boy_script : MonoBehaviour
{
    public AudioClip Hello_1;
    public AudioClip Tell_me_about_yourself_2;
    public AudioClip Dog_task_3;
    public AudioClip Dog_likes_you_4;
    public AudioClip Apple_task_5;
    public AudioClip Apple_count_6;
    public AudioClip Good_job_8;
    public AudioClip Chicken_9;
    public AudioClip This_is_amazing_10;
    public AudioClip Good_bye_11;


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

    void hello1_Play()
    {
        Real_Boy_audio.PlayOneShot(Hello_1);
    }
    void about_yourself_Play()
    {
        Real_Boy_audio.PlayOneShot(Tell_me_about_yourself_2);
    }
    void Dog_Play()
    {
        Real_Boy_audio.PlayOneShot(Dog_task_3);
    }
    void Dog_like_Play()
    {
        Real_Boy_audio.PlayOneShot(Dog_likes_you_4);
    }
    void Apple_task_play()
    {
        Real_Boy_audio.PlayOneShot(Apple_task_5);
    }
    void Apple_count_play()
    {
        Real_Boy_audio.PlayOneShot(Apple_count_6);
    }

    void Good_job_play()
    {
        Real_Boy_audio.PlayOneShot(Good_job_8);
    }
    void Chicken_play()
    {
        Real_Boy_audio.PlayOneShot(Chicken_9);
    }
    void This_is_amazing_play()
    {
        Real_Boy_audio.PlayOneShot(This_is_amazing_10);
    }

    void good_bye_play()
    {
        Real_Boy_audio.PlayOneShot(Good_bye_11);
    }
    
}
