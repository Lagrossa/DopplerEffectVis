using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reactor : MonoBehaviour
{
    public GameObject trigger;
    public float radius;
    public float rangeOfViability;
    private void OnDrawGizmos()
    {
        if(trigger.GetComponent<Radial>().radius >= (transform.position - trigger.transform.position).magnitude - rangeOfViability && trigger.GetComponent<Radial>().radius <= (transform.position - trigger.transform.position).magnitude + rangeOfViability)
        {
            Gizmos.color = Color.green;
        }
        else
        {
            Gizmos.color = Color.white;
        }

        Gizmos.DrawSphere(transform.position, radius);
    }
}
