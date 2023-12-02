using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBehavior : MonoBehaviour
{

    [SerializeField]GameObject ball;
    private void OnTriggerEnter(Collider other)
    {
        if (other != null && other.tag == "Ball")
        {
            Instantiate(ball);
            this.gameObject.SetActive(false);
        }
    }
}
