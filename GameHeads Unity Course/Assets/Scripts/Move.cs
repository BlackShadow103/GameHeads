using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    //Amount of units to move per second
    public Vector3 speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentSpeed = Vector3.zero;

        if (Input.GetKeyDown(KeyCode.A))
        {
            currentSpeed.x = -speed.x;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            currentSpeed.x = speed.x;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            currentSpeed.z = speed.z;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            currentSpeed.z = -speed.z;
        }

        //Speed us a Vector3 defines how fast to move in 3D space
        gameObject.transform.Translate(currentSpeed * Time.deltaTime);
    }
}