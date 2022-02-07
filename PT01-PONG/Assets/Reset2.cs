using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset2 : MonoBehaviour
{
    public int scl;
    void OnCollisionEnter(Collision collision)
    {
        GameObject left = GameObject.Find("Left");
        Reset reset = left.GetComponent<Reset>();
        scl++;
        if (scl == 11)
        {
            Debug.Log("Left Wins!");
            scl = 0;
            reset.scr = 0;
        }
        else
        {
            Debug.Log("Left Scored! " + scl);
        }
        Ball ball = collision.gameObject.GetComponent<Ball>();
        ball.transform.position = new Vector3(0f, 0.5f, 0f);
    }
    
}
