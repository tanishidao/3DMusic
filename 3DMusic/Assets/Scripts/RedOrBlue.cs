using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedOrBlue : MonoBehaviour
{
    public GameObject Guitarhere;
    public GameObject Basehere;
   
    public int ChangeCount;
    private bool Guitar;
    private bool Base;
 

    void Start()
    {
        Guitar = true;
        Base = false;
       
        ChangeCount = 0;
        Guitarhere.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))  // Guitar On;
        {
            Base = false;
            Guitar = true;
           


        }
        if (Input.GetKeyDown(KeyCode.Alpha2)) ///Base ON
        {
            Base = true;
            Guitar = false;
            
        }
        


        if (Base == true)
        {
            Guitarhere.SetActive(false);
            
            Basehere.SetActive(true);

        }
       
        
        if (Guitar == true)
        {
            Guitarhere.SetActive(true);
            
            Basehere.SetActive(false);
        }

    }



}
