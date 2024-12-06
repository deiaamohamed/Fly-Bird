using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class cloudSpawner : MonoBehaviour
{
    public GameObject cloud;
    public float highest = 7;
    public float spawnRate = 12;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        spawn();   
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawn();
            timer = 0;
        }
    }
     void spawn()
    {
        float lowestPoint = transform.position.y - highest;
        float highestPoint = transform.position.y + highest;
        Instantiate(cloud, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);

    }
}
