using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public Logic logic;
    bool birdalive = true;
    

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)==true&&birdalive)
        {
            myRigidbody.velocity = Vector2.up*flapStrength;

        }
        if (transform.position.y > 17.6)
        {
            
            logic.gameover();
            birdalive = false;

        }
    }
 
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
            logic.gameover();
        birdalive= false;
        
    }
}
