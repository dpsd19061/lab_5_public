using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeControl : MonoBehaviour
{
    public float vel = 0.25f;
    public bool moveRight = true;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("HERRO");
        //transform.position = new Vector3(-5, 0.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(moveRight)
        {
            transform.Translate(vel * Time.deltaTime, 0, 0);//Space.World
            if(transform.position.x > 4.5f)
            {
                moveRight = false;
            }
        }
        else
        {
            transform.Translate(-vel * Time.deltaTime, 0, 0);
            if (transform.position.x < -4.5f)
            {
                moveRight = true;
            }
        }
    }
}
