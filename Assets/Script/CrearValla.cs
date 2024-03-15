using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearValla : MonoBehaviour
{
    public GameObject[] prefabs;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPrefabs();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnPrefabs()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < prefabs.Length; i++)
            {
                Instantiate(prefabs[i]);
            }
        }
    }
}
