using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class RotateOverTime : MonoBehaviour
{
    public float speed = 15;
    public Vector3 axis = Vector3.up;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(axis, speed * Time.deltaTime);
    }
}
