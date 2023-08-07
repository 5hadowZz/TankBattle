using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAbout : MonoBehaviour
{
    public Transform target;
    public float rotateSpeed = 100f;

    void Update()
    {
        transform.LookAt(target);

        if ( Input.GetMouseButton(1) )
        {
            transform.RotateAround(target.position, Vector3.up, rotateSpeed * Time.deltaTime * Input.GetAxis("Mouse X"));
        }
    }
}
