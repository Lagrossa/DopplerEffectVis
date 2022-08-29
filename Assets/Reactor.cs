using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reactor : MonoBehaviour
{
    public GameObject trigger;

    private void Update()
    {
        if(trigger.GetComponent<Radial>().radius > (transform.position - trigger.transform.position).magnitude)
        {

        }
    }
}
