using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sheep_anim : MonoBehaviour
{

    Animation sheep_anims;
    // Start is called before the first frame update
    void Start()
    {
        sheep_anims = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) {
            sheep_anims.Play("walk");
        }
        
    }

    
}
