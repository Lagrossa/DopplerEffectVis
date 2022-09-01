using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Radial : MonoBehaviour
{
    [Range(0,1)]
    public float colorR;
    [Range(0, 1)]
    public float colorG;
    [Range(0, 1)]
    public float colorB;
    public float radius; // Size of expansion
    public float speed;
    // Use OOP to classify the rays as individual objects and if that object overlaps with a circle then it will light it green
    // - Only set it green for the duration of the collision
    // Change it from radial [containing] to collision based
    // Loop through multiple rays which expand to a designated radius (can still be assigned here)
    // Possibly include moving circles
    // Calculate the frequency in which a circle is activated by getting the time from the current activation to the previous
    // Used to display that an object at a further distance will have a 

    private void Start()
    {
        //initialize all values
        colorR = transform.GetComponentInParent<Radial>().colorR;
        colorG = transform.GetComponentInParent<Radial>().colorG;
        colorB = transform.GetComponentInParent<Radial>().colorB;
        speed = transform.GetComponentInParent<Radial>().speed;



    }

    void OnDrawGizmos()
    {
        radius += speed;
        Handles.color = new Color(colorR, colorG, colorB);
        Handles.DrawWireDisc(transform.position, Vector3.forward, radius);

        if(radius > 7 || radius < -7)
        {
            radius = 0;
        }

        SceneView.RepaintAll();    
    }
}
