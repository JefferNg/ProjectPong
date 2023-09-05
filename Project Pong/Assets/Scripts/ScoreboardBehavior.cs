using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreboardBehavior : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI score;
    int point = 0;

    public void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag.Equals("Player1"))
        {
            point++;
            score.text = point + ":";
        }
        else if (gameObject.tag.Equals("Player2"))
        {
            point++;
            score.text = point + "";
        }

    }

}
