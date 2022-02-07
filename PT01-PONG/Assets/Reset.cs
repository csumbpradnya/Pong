using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public int scr = 0;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        scr++;
        GameObject right = GameObject.Find("Right");
        Reset2 reset2 = right.GetComponent<Reset2>();
        if (scr == 11)
        {
            Debug.Log("Right Wins!");
            scr = 0;
            reset2.scl = 0;
        }
        else
        {
            Debug.Log("Right Scored! " + scr);
        }
        Ball ball = collision.gameObject.GetComponent<Ball>();
        ball.transform.position = new Vector3(0f, 0.5f, 0f);
    }
    
    

    
}
