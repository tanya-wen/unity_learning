using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class People : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody peopleRb;
    public float minSpeed = 12;
    public float maxSpeed = 16;
    public float xRange = 20;
    public float zPos = 20;
    public float lowerBound = -20;
    
    void Start()
    {
        peopleRb = GetComponent<Rigidbody>();
        transform.position = RandomSpawnPos();

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * Random.Range(minSpeed, maxSpeed));
        if (transform.position.z < lowerBound) 
        {
            Destroy(gameObject);
        }
    }


    Vector3 RandomSpawnPos() 
    {
        return new Vector3(Random.Range(-xRange, xRange), 0, zPos);
    }

    private void OnMouseDown() 
    {
        Destroy(gameObject);
    }
}

