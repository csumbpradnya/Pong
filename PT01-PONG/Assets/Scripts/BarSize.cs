using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarSize : MonoBehaviour
{
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
                GameObject paddle = GameObject.Find("Left");
                Reset reset= paddle.GetComponent<Reset>();
                reset.flag = true;
            }
        }
    }
}
