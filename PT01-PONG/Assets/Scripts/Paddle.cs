using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool isLeft;

    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isLeft)
        {
            transform.Translate(0f, 0f, Input.GetAxis("Left")*speed*Time.deltaTime);
        }
        else
        {
            transform.Translate(0f, 0f, Input.GetAxis("Right")*speed*Time.deltaTime);
        }
    }
}
