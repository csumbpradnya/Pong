using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //public float speed = 5f;
    public Vector3 force;
    //Start is called before the first frame update
    void Start()
    {
        Rigidbody Ball = GetComponent<Rigidbody>();
        Ball.AddForce(force,ForceMode.Impulse);
        
        //float speed_x = Random.Range(0, 2) == 0? -1: 1;
        //float speed_y = Random.Range(0, 2) == 0? -1: 1;
        //Ball.velocity = new Vector3(speed * speed_x, speed * speed_y, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
}
