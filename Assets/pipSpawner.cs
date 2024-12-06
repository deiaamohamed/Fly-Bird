using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipSpawner : MonoBehaviour
{
    public GameObject pip;
    public float spawnRate=2;
    private float timer = 0;
    public float highoffset = 10;
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
        else {
            spawn();
                timer = 0;
         }
    }
    void spawn()
    {
        float lowestPoint = transform.position.y - highoffset; 
        float highestPoint = transform.position.y + highoffset;
        Instantiate(pip, new Vector3(transform.position.x,Random.Range(lowestPoint,highestPoint),0), transform.rotation);

    }
}
