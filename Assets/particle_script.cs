using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particle_script : MonoBehaviour
{
    ParticleSystem firework;
    // Start is called before the first frame update
    void Start()
    {
        firework = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) {
            firework.Play();
        }
        
    }
}
