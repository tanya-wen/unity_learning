using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cop : People
{
    public float minSpin = 4;
    public float maxSpin = 2;
    private void Update() 
    {
        peopleRb.AddTorque(Vector3.up * Random.Range(minSpin,maxSpin), ForceMode.Impulse);
    }

}
