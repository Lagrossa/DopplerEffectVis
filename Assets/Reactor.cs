using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reactor : MonoBehaviour
{
    public GameObject pulseManager1;
    public GameObject trigger;
    public float radius;

    //Frequency Manager
    public float currentTime;
    public float lastTick;
    public float frequency;
    public float rangeOfViability;

    public bool checking;
    public float checkTimer;
    private void OnDrawGizmos()
    {
        
        currentTime = Time.time;
        List<GameObject> pList = pulseManager1.GetComponent<PulseManager>().pulseList;
        for (int x = 0; x<pulseManager1.GetComponent<PulseManager>().pulseList.Count; x++)
        {
            trigger = pList[x];
            if (checking && trigger.GetComponent<Radial>().radius >= (transform.position - trigger.transform.position).magnitude - rangeOfViability && trigger.GetComponent<Radial>().radius <= (transform.position - trigger.transform.position).magnitude + rangeOfViability)
            {
                Gizmos.color = Color.green;
                frequency = currentTime - lastTick;
                lastTick = currentTime;
                checking = false;
            }
            else
            {
                Gizmos.color = Color.white;
            }

        }
        if (!checking)
        {
            checkTimer += .1f;
            if(checkTimer >= 2)
            {
                checking = true;
                checkTimer = 0f;
            }
        }

        Gizmos.DrawSphere(transform.position, radius);
    }
}
