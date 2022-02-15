using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Modify : MonoBehaviour
{
    public float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody cube = GetComponent<Rigidbody>();
        cube.AddForce(Vector3.forward,ForceMode.Impulse);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //MoveCube();
        Rigidbody cube = GetComponent<Rigidbody>();
        if (cube.position.z > 3.33)
        {
            cube.AddForce(Vector3.back,ForceMode.Impulse);
        }
        else if(cube.position.z <-3.33)
        {
            cube.AddForce(Vector3.forward,ForceMode.Impulse);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other != null)
        {
            if (other.gameObject.name == "Ball")
            {
                GameObject ball = GameObject.Find("Ball");
                //ball.transform.localScale = new Vector3(1,1,1);
                Ball Ball = ball.GetComponent<Ball>();
                Ball.flag = true;
            }
        }
    }
}
