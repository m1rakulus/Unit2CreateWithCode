using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float nextSpawn = 0.0f;
    public float spawnDelay = 0.5f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space)&& Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnDelay;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            
        }
    }
}
