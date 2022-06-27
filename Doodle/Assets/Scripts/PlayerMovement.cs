using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    public float movementPower = 2;
    public int Score;
    public int CoinsCount;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<CoinsScript>())
        {
            CoinsCount = CoinsCount + 10;
        }
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal") * movementPower;
        Vector3 newMovement = rb.velocity;
        newMovement.x = horizontalMovement;
        rb.velocity = newMovement;
        int checkScore =Mathf.RoundToInt (transform.position.y * 100);
        if (checkScore > Score)
            Score = checkScore;

    }
}
