using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public AudioSource collect;
    public AudioSource gameover;
    public player playerScript;
    public Score score;
    public GameController gamecontroller;
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag=="obstacle")
        {
            gameover.Play();
           
            playerScript.enabled = false;

            gamecontroller.GameOver();
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "collectibles")
        {
            collect.Play();
            score.addScore(1);
            Destroy(other.gameObject);
        }

    }
}
