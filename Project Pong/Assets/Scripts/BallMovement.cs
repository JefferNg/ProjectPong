using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.VirtualTexturing.Debugging;

public class BallMovement : MonoBehaviour
{
    //[SerializeField] float speed = 10f;
    [SerializeField] float maxVelocity = 0f;
    private ballState state = ballState.start;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case ballState.start:
                transform.position = new Vector3(0, 0, 0);
                if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
                {
                    state = ballState.playing;
                    int ranNum = Random.Range(0, 2);

                    if (ranNum == 0)
                    {
                        rb.AddForce(Vector3.up * maxVelocity);
                    }
                    else
                    {
                        rb.AddForce(Vector3.down * maxVelocity);
                    }

                    ranNum = Random.Range(0, 2);

                    if (ranNum == 0)
                    {
                        rb.AddForce(Vector3.left * maxVelocity);
                    }
                    else
                    {
                        rb.AddForce(Vector3.right * maxVelocity);
                    }

                    //float max = 15f;
                    //rb.velocity = new Vector2(Random.Range(-10, 10) + Mathf.Clamp(rb.velocity.x, -max, max), 10f);
                }
                break;

            case ballState.playing:
                if (transform.position.x < -10f || transform.position.x > 10f)
                {
                    state = ballState.start;
                    transform.position = new Vector3(0, 0, 0);
                    rb.velocity = Vector3.zero;
                }
                //rb.velocity = new Vector2(Mathf.Clamp(rb.velocity.x, -maxVelocity, maxVelocity), Mathf.Clamp(rb.velocity.y, -maxVelocity, maxVelocity));
                break;
        }

        Debug.Log(rb.velocity);
    }

    enum ballState
    {
        start,
        playing
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player1")
        {
            Debug.Log("Add right force");
        }
        else if (other.gameObject.tag == "Player2")
        {
            Debug.Log("Add left force");
        }
    }

}
