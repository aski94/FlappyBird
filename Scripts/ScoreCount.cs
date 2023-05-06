using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class ScoreCount : MonoBehaviour
{
    public static int score = 0;

    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();
    }

}
