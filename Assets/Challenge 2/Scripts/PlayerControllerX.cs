using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    GameObject dog;

    private void Start()
    {
        dog = null;
    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(dog == null)
            {
                dog = Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            }
        }
    }
}
