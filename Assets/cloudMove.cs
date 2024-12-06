using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudMove : MonoBehaviour
{
    public float moveSpeed = 30;
    public float deadcloud = -30.4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position =transform.position+ (Vector3.left * moveSpeed) * Time.deltaTime;
        if (transform.position.x < deadcloud)
        {
            Destroy(gameObject);
        }
    }
}
