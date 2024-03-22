using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float jumpForce;
    public GameObject bullet;
    public GameObject padre;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            GameObject bala = Instantiate(bullet, padre.transform.position, Quaternion.Euler(0,0,0));
            bala.GetComponent<Rigidbody>().AddForce(new Vector3(0,0, -1 * jumpForce));
        }
    }
}
