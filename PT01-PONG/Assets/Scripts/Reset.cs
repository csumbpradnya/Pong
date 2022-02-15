using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public int scr = 0;
    private UIManager _uiManager;

    public bool flag = false;
    // Start is called before the first frame update
    private void Start()
    {
        _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
        if (_uiManager == null)
        {
            Debug.LogError("The UI Manager is NULL");
        }
    }

    private void Update()
    {
        if (flag)
        {
            GameObject paddle = GameObject.Find("Paddle1");
            paddle.transform.localScale = new Vector3(0.3f, 0.2f, 4);
            StartCoroutine(ExampleCoroutine());
            //flag = false;
        }
        
    }
    IEnumerator ExampleCoroutine()
    {
        flag = false;
        GameObject paddle = GameObject.Find("Paddle1");
        yield return new WaitForSeconds(5);
        paddle.transform.localScale = new Vector3(0.3f,0.2f,2.5f);
        flag = false;
    }

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
        if (_uiManager != null)
        {
            _uiManager.UpdateScoreRight();
        }
        Ball ball = collision.gameObject.GetComponent<Ball>();
        ball.transform.position = new Vector3(0f, 0.5f, 0f);
    }
    
    

    
}
