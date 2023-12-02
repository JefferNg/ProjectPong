using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] float PowerUpDelay = 5f;
    [SerializeField] GameObject PowerUp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (PowerUpDelay > 0)
        {
            PowerUpDelay -= Time.deltaTime;
        }
        else
        {
            if (!PowerUp.activeSelf)
            {
                PowerUpDelay = 5f;
                PowerUp.SetActive(true);
            }
        }
    }
}
