using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    public float speed = 0.01f;
    public float jump = 5;
    public float forward = 10;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Input.GetAxis("Horizontal")*speed*Time.deltaTime, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime, Space.World);

        rb.velocity += new Vector3(Input.GetAxis("Horizontal") * speed, 0, Input.GetAxis("Vertical") * speed);

        if (Input.GetButtonDown("Fire1"))
        {
           rb.velocity = new Vector3(0, jump, forward);
        }

    }
}
