using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    public static int Score = 0;
    public GameManagement gameManagement;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.layer == 6)
        {
            gameManagement.Death();
        }
        else if (col.gameObject.layer == 7)
        {
            Debug.Log("Score");
            ScoreCount.score++;
        }
    }  


}
