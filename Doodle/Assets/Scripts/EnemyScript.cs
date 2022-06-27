using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject lostCanvas;
    public DestroyerScript DestroyerScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>())
        {
            Destroy(other.gameObject);
            FindObjectOfType<DestroyerScript>().canvasOn();

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
