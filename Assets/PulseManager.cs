using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulseManager : MonoBehaviour
{
    public GameObject Pulse;
    public float pulsi;
    public List<GameObject> pulseList;
    private void Start()
    {
       for(int x = 0; x < pulsi; x++)
        {
            GameObject newPulse = GameObject.Instantiate<GameObject>(Pulse);
            newPulse.transform.parent = transform;
            pulseList.Add(newPulse);
        }
    }
    private void Update()
    {
        
    }
}
