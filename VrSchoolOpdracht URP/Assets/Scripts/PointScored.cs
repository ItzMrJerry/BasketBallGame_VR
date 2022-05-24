using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
public class PointScored : MonoBehaviour
{
    public int Points = 0;
    public TMP_Text ScoreText;
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.gameObject.tag == "Ball")
        {
            Points++;
            ScorePoint();
        }
    }


    public void ScorePoint()
    {
        ScoreText.text = "" + Points;
    }
}
