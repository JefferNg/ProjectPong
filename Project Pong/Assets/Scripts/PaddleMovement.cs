using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    public float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        if (tag.Equals("Player1"))
        {
            if (Input.GetKey(KeyCode.W) && transform.position.y <= 2.5)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S) && transform.position.y >= -2.5)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + -speed * Time.deltaTime);
            }
        }
        if (tag.Equals("Player2"))
        {
            if (Input.GetKey(KeyCode.UpArrow) && transform.position.y <= 2.5)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.DownArrow) && transform.position.y >= -2.5)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + -speed * Time.deltaTime);
            }
        }
    }
}
