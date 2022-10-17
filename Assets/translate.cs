using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class translate : MonoBehaviour
{
    int flip;
    // Start is called before the first frame update
    void Start()
    {
        flip = -1;
    }
    //movement speed in units per second
    private float movementSpeed = 15f;
    // Update is called once per frame
    void Update()
    {
        //update the position

        transform.position = transform.position + new Vector3(movementSpeed * Time.deltaTime * flip * 1/10, 0, 0);
        //output to log the position change
        // Debug.Log(transform.position);

        if (transform.position.x > 9 || transform.position.x < -9) {
            flip *= -1;
        }
    }
}