using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundMovement : MonoBehaviour
{
    public float speed;
    [SerializeField]
    private Renderer bgrender;

    // Update is called once per frame
    void Update()
    {
        bgrender.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }
}
