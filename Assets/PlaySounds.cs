using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySounds : MonoBehaviour
{
    
    public AudioClip hello;
    public AudioClip hand;
    public AudioClip goodjob;
    AudioSource Farmer_audio;

    // Start is called before the first frame update
    void Start()
    {
        Farmer_audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void helloPlay() {
        Farmer_audio.PlayOneShot(hello);
    }
    void handPlay()
    {
        Farmer_audio.PlayOneShot(hand);
    }
    void goodJobPlay()
    {
        Farmer_audio.PlayOneShot(goodjob);
    }
}
