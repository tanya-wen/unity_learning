using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> people;
    private float spawnRate = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnPeople());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnPeople()
    {
        while(true) 
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, people.Count);
            Instantiate(people[index]);
        }
    }
}
