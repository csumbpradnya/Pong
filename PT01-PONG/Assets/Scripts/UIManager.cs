using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private int leftScore;

    [SerializeField] private TMP_Text leftScoreText;

    [SerializeField] private int rightScore;

    [SerializeField] private TMP_Text rightScoreText;
    // Start is called before the first frame update
    void Start()
    {
        leftScore = 0;
        rightScore = 0;
        leftScoreText.text = "L " + leftScore.ToString();
        rightScoreText.text = "R " + rightScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void UpdateScoreLeft()
    {
        leftScore++;
        leftScoreText.text = "L " + leftScore.ToString();
        if (leftScore < rightScore)
        {
            leftScoreText.color = Color.magenta;
            rightScoreText.color = Color.green;
        }
        else if (leftScore > rightScore)
        {
            leftScoreText.color = Color.green;
            rightScoreText.color = Color.magenta;
        }
        else if (leftScore == rightScore)
        {
            leftScoreText.color = Color.white;
            rightScoreText.color = Color.white;
        }
        if (leftScore == 11 || rightScore == 11)
        {
            leftScore = 0;
            rightScore = 0;
            leftScoreText.color = Color.white;
            rightScoreText.color =Color.white;
        }
    }

    public void UpdateScoreRight()
    {
        rightScore++;
        rightScoreText.text = "R " + rightScore.ToString();
        if (leftScore < rightScore)
        {
            leftScoreText.color = Color.magenta;
            rightScoreText.color = Color.green;
        }
        else if (leftScore > rightScore)
        {
            leftScoreText.color = Color.green;
            rightScoreText.color = Color.magenta;
        }
        else if (leftScore == rightScore)
        {
            leftScoreText.color = Color.white;
            rightScoreText.color = Color.white;
        }
        if (rightScore == 11 || rightScore == 11)
        {
            rightScore = 0;
            leftScore = 0;
            leftScoreText.color = Color.white;
            rightScoreText.color =Color.white;
        }
    }
}
