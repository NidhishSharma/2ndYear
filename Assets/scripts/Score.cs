using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text finalscore;
    public Text scoreText;
    public int Myscore = -1;
    void Update()
    {
        scoreText.text = Myscore.ToString();
        finalscore.text = Myscore.ToString();
    }
    public void addScore(int score)
    {
        Myscore = Myscore + score;
    }

}
