using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + offset;

        /*
        Quaternion newRotation = Quaternion.Euler(transform.rotation.eulerAngles.x,
                    target.rotation.eulerAngles.y,
                    transform.rotation.eulerAngles.z);
        transform.rotation = newRotation;
        */

    }
}
