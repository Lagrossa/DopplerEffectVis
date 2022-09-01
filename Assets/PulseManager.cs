using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulseManager : MonoBehaviour
{
    public GameObject Pulse;
    public float pulsi;
    public List<GameObject> pulseList;

    //Pulse Basics
    [Range(0, 1)]
    public float colorR;
    [Range(0, 1)]
    public float colorG;
    [Range(0, 1)]
    public float colorB;

    public float speed;

    private void Start()
    {
       for(int x = 0; x < pulsi; x++)
        {
            GameObject newPulse = GameObject.Instantiate<GameObject>(Pulse);
            newPulse.transform.parent = transform;
            newPulse.GetComponent<Radial>().colorR = colorR;
            newPulse.GetComponent<Radial>().colorG = colorG;
            newPulse.GetComponent<Radial>().colorB = colorB;
            newPulse.GetComponent<Radial>().speed = speed;
            pulseList.Add(newPulse);
        }
    }
    private void Update()
    {
        
    }
}
