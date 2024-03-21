using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public int jumpForce = 400;
    public Rigidbody physics;
    private bool canjump = true;
    // Start is called before the first frame update
    void Start()
    {
        physics = this.GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        Saltar();
    }

    private void Saltar()
    {
        Vector3 inputDir = new Vector3(0, 1, 0);
        if (canjump && Input.GetKeyDown(KeyCode.Space)) physics.AddForce(inputDir * jumpForce, ForceMode.Impulse);
    }

    public void OnCollisionExit(Collision collision)
    {
        canjump = false;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("ground"))
        {
            canjump = true;
        }
    }
}
