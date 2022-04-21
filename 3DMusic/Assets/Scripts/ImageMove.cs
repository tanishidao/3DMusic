using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageMove : MonoBehaviour
{
    public float MoveSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, MoveSpeed, 0);
    }
}
