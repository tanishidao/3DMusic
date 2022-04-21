using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimingImageGene : MonoBehaviour
{
    public GameObject MovingTime;
    public float Spawn;
    private float seconds;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        seconds += Time.deltaTime;
        if (Spawn < seconds)
        {
            Spwan();
            seconds = 0;
        }
    }
    public void Spwan()
    {
        
        Instantiate(MovingTime, new Vector3(-850, 580, 0), Quaternion.identity); 

    }
}
