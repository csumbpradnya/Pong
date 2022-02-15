using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;


public class Ball : MonoBehaviour
{
    public float speed = 5f;
    public Vector3 force;

    public AudioSource BallAudioSource;

    public AudioClip pew;

    public AudioClip whoosh;

    public bool flag = false;
    //Start is called before the first frame update
    void Start()
    {
        Rigidbody Ball = GetComponent<Rigidbody>();
        //Ball.AddForce(force,ForceMode.Impulse);
        
        float speed_x = Random.Range(0, 2) == 0? -1: 1;
        float speed_y = Random.Range(0, 2) == 0? -1: 1;
        //Ball.velocity = new Vector3(speed * speed_x, speed * speed_y, 0f);
        Ball.velocity = new Vector3(speed , 0f , speed);
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody Ball = GetComponent<Rigidbody>();
        float speed_x = Random.Range(0, 2) == 0? -1: 1;
        float speed_y = Random.Range(0, 2) == 0? -1: 1;
        if (Ball.transform.position == new Vector3(0f, 0.5f, 0f))
        {
            //ball.velocity = Vector3.zero;
            //ball.AddForce(force, ForceMode.Impulse);
            //Ball.velocity = new Vector3(speed * speed_x, speed * speed_y, 0f);
            Ball.velocity = new Vector3(speed , 0f , speed);
        }

        if (flag)
        {
            transform.localScale = new Vector3(1, 1, 1);
           StartCoroutine(ExampleCoroutine());
           //flag = false;
        }
    }
    
    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(5);
        transform.localScale = new Vector3(0.5f,0.5f,0.5f);
        flag = false;
    }


    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody Ball = GetComponent<Rigidbody>();
        
        //code to set speed according to which paddle ball hit and what part (upper/lower)
        if (collision.collider.name == "upper1")
        {
            BallAudioSource.PlayOneShot(pew);
            Ball.velocity = new Vector3(speed , 0f , speed);
        }
        else if (collision.collider.name == "upper2")
        {
            BallAudioSource.PlayOneShot(pew);
            Ball.velocity = new Vector3(-speed, 0f, speed);
        }
        else if(collision.collider.name == "lower1") 
        {
            BallAudioSource.PlayOneShot(whoosh);
            Ball.velocity = new Vector3(speed, 0f, -speed);
        }

        else if(collision.collider.name == "lower2")
        {
            BallAudioSource.PlayOneShot(whoosh);
            Ball.velocity = new Vector3(-speed, 0f, -speed);
        }
        
    }
}
