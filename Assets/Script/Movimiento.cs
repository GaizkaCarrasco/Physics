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
        //checkMovement();
        Movement();
        Rotation();
    }

    private void checkMovement()
    {
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.localPosition = new Vector3(this.transform.localPosition.x, this.transform.localPosition.y, this.transform.localPosition.z + velocityZ * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.localPosition = new Vector3(this.transform.localPosition.x, this.transform.localPosition.y, this.transform.localPosition.z - velocityZ * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.localPosition = new Vector3(this.transform.localPosition.x + velocityX * Time.deltaTime, this.transform.localPosition.y, this.transform.localPosition.z);
        }
        if (Input.GetKey(KeyCode.S))
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

    private void Rotation()
    {
        float rotateDirX = 0f;
        float rotateDirY = 0f;
        if (Input.GetKey(KeyCode.LeftArrow)) rotateDirX = -1f;
        if (Input.GetKey(KeyCode.RightArrow)) rotateDirX = 1f;

        float rotateSpeed = 100f;

        transform.eulerAngles += new Vector3(rotateDirY * rotateSpeed * Time.deltaTime, rotateDirX * rotateSpeed * Time.deltaTime, 0);
    }

    private void Movement()
    {
        Vector3 inputDir = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.S)) inputDir.z = 1f;
        if (Input.GetKey(KeyCode.W)) inputDir.z = -1f;
        if (Input.GetKey(KeyCode.D)) inputDir.x = -1f;
        if (Input.GetKey(KeyCode.A)) inputDir.x = 1f;

        Vector3 moveDir = transform.forward * inputDir.z + transform.right * inputDir.x + transform.up * inputDir.y;

        float movespeed = 10f;
        transform.position += moveDir * movespeed * Time.deltaTime;
    }
}
