using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GetNotes : MonoBehaviour
{
    private bool Destroyed;
    public bool Hit;
    public GameObject HitImage;

    private float Destroytime;   
    void Start()
    {
        Hit = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        while (Destroyed == false)
        {
            HitImage.SetActive(false);
            Hit = false;
            break;
        }
        while (Destroyed == true)
        {
            Destroytime += Time.deltaTime;
            Hit = true;
            HitImage.SetActive(true);
            break;
        }
        if (Destroyed == true && 0.1f < Destroytime)
        {

            Destroyed = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Destroyed = true;

    }
}
