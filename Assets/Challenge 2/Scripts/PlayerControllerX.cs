using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float firedelay=20.0f;

    // Update is called once per frame
    void Update()
    {
        firedelay -= 0.01f;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space)&& firedelay <= 0.0f)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            firedelay = 20.0f;
        }
    }
}
