using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform head;
    public float moveSpeed = 10f;
    public float rotateSpeed = 60f;
    public float headRotateSpeed = 400f;

    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        // 移动
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime * Input.GetAxis("Vertical"));
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));

        // 鼠标旋转头部
        head.Rotate(Vector3.up * headRotateSpeed * Time.deltaTime * Input.GetAxis("Mouse X"));
    }
}
