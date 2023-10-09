using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_control : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = 5 * Input.GetAxis("Mouse X");
        float y = 5 * -Input.GetAxis("Mouse Y");
        transform.Rotate(0, x, 0);
        rb.velocity = new Vector3(Input.GetAxis("Vertical") * 2f, rb.velocity.y, Input.GetAxis("Horizontal") * 2f);
    }
}
