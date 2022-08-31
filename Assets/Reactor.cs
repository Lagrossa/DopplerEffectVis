using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reactor : MonoBehaviour
{
    public GameObject trigger;
    public float radius;

    //Frequency Manager
    private float currentTick;
    private float lastTick;
    public float frequency;
    public float rangeOfViability;

    private void OnDrawGizmos()
    {
        if(trigger.GetComponent<Radial>().radius >= (transform.position - trigger.transform.position).magnitude - rangeOfViability && trigger.GetComponent<Radial>().radius <= (transform.position - trigger.transform.position).magnitude + rangeOfViability)
        {
            Gizmos.color = Color.green;
            currentTick = Time.time;
            frequency = lastTick - currentTick;
            lastTick = currentTick;
        }
        else
        {
            Gizmos.color = Color.white;
        }

        Gizmos.DrawSphere(transform.position, radius);
    }
}
