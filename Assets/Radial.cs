using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Radial : MonoBehaviour
{
    public float radius;

    public void Start()
    {
_
    }
    void OnDrawGizmos()
    {
        Handles.color = Color.blue;
        Handles.DrawWireDisc(transform.position, Vector3.forward, radius);
    }
}
