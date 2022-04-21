using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GetNotes : MonoBehaviour
{
    public bool Destroyed;
    public bool Hit;
   
    public GameObject HitImage;
    public GameObject HPImage; //HpGauge

    private float Destroytime;
    private float DamagePoint = 0.08f;
    private float HealPoint = 0.05f;
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


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Destroyed = true;
            Destroy(collision.gameObject);
            
           
            
                HPImage.GetComponent<Image>().fillAmount -= DamagePoint;
            
        }
        if(collision.gameObject.CompareTag("Heal"))
        {
            Destroyed = true;
            Destroy(collision.gameObject);
            HPImage.GetComponent<Image>().fillAmount += HealPoint;
        }
    }
}
