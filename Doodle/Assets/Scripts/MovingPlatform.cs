using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{

    bool move;
    [Range(4, 20)]
    public float jumpForce;
    void start()
    {

    }


    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>())
        { Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb.velocity.y < 0)

            {
                Vector3 newVelocity = rb.velocity;
                newVelocity.y = jumpForce;
                        rb.velocity = newVelocity;
                GetComponent<AudioSource>().Play();
            }
        }
        }
        // Update is called once per frame
        void Update()
    {
        if (move)
        {
            transform.Translate(2.5f * Time.deltaTime, 0, 0);
            if (transform.position.x>= 2.8f)
                move = false;

        }
        else
        {
            transform.Translate(-2.5f * Time.deltaTime, 0, 0);
            if (transform.position.x<= -2.8)
                move = true;
        }
        
        }
    }


