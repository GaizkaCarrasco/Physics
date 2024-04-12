using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iluminate : MonoBehaviour
{
    public GameObject enemyArealight;
    // Start is called before the first frame update
    void Start()
    {
        enemyArealight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.I))
        {
            enemyArealight.SetActive(true);
        } else
        {
            enemyArealight.SetActive(false);
        }
    }
}
