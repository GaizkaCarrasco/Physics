using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("He sido golpeado con " + collision.gameObject.name);
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("He atravesado a " + other.gameObject.name);
    }
}
