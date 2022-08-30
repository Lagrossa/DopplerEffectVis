using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Radial : MonoBehaviour
{
    public float radius;

   
    void OnDrawGizmos()
    {
        radius += .01f;
        Handles.color = Color.blue;
        Handles.DrawWireDisc(transform.position, Vector3.forward, radius);

        if(radius > 7)
        {
            radius = 0;
        }

        SceneView.RepaintAll();    
    }
}
