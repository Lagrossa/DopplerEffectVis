using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reactor : MonoBehaviour
{
    public GameObject trigger;
    public float radius;

    private void OnDrawGizmos()
    {
        if(trigger.GetComponent<Radial>().radius >= (transform.position - trigger.transform.position).magnitude)
        {
            Gizmos.color = Color.green;
        }
        else
        {
            Gizmos.color = Color.gray;
        }

        Gizmos.DrawSphere(transform.position, radius);
    }
}
