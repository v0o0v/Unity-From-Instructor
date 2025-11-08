using System;
using UnityEngine;

public class AmongusController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float turnSpeed = 5f;
    
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 dir = new Vector3(h, 0, v).normalized;

        Move(dir);

        if (h == 0 && v == 0)
            return;

        Turn(dir);
    }

    public void Move(Vector3 _dir)
    {
        transform.position += _dir * moveSpeed * Time.deltaTime;
    }

    public void Turn(Vector3 _dir)
    {
        Quaternion newRotation = Quaternion.LookRotation(_dir);

        transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, turnSpeed * Time.deltaTime);
    }
}