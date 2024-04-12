using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IlluminateSun : MonoBehaviour
{
    public GameObject night;
    public GameObject sun;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.L))
        {
            sun.SetActive(true);
            night.SetActive(false);
        }
        else
        {
            sun.SetActive(false);
            night.SetActive(true);
        }
    }
}
