using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public int velocityX = 10;
    public int velocityY = 10;
    public int velocityZ = 10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        checkMovement();
    }

    private void checkMovement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.localPosition = new Vector3(this.transform.localPosition.x, this.transform.localPosition.y, this.transform.localPosition.z + velocityZ * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.localPosition = new Vector3(this.transform.localPosition.x, this.transform.localPosition.y, this.transform.localPosition.z - velocityZ * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.localPosition = new Vector3(this.transform.localPosition.x + velocityX * Time.deltaTime, this.transform.localPosition.y, this.transform.localPosition.z);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.localPosition = new Vector3(this.transform.localPosition.x - velocityX * Time.deltaTime, this.transform.localPosition.y, this.transform.localPosition.z);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            this.transform.localPosition = new Vector3(this.transform.localPosition.x, this.transform.localPosition.y + velocityY * Time.deltaTime, this.transform.localPosition.z);
        }
        if (Input.GetKey(KeyCode.E))
        {
            this.transform.localPosition = new Vector3(this.transform.localPosition.x, this.transform.localPosition.y - velocityY * Time.deltaTime, this.transform.localPosition.z);
        }
    }
}
