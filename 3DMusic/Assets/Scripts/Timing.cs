using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timing : MonoBehaviour
{
    public GameObject Player;
   
    public float TimingTime;
    public GameObject TimingImage;
   
    private float time;
    private float GoodInte;
    private bool Goodbool;
    public bool EnemyDamage;
    //EnemyHpGauge
    public GameObject HPImage;
    public float AttackPoint;
    void Start()
    {
        TimingImage.SetActive(false);
        Goodbool = false;
       
    }

    // Update is called once per frame
    void Update()
    {
        
        time += Time.deltaTime;
        GoodInte += Time.deltaTime;
        if (0.5 < GoodInte)//good判定のインターバルタイム
        {
            Goodbool = false;
            GoodInte = 0;
            TimingImage.SetActive(false);
        }
        if (TimingTime < time)///
        {
            Goodbool = true;
            
            time = 0;
           


            while (Goodbool == true)
            {

             
                TimingImage.SetActive(true);
                break;




            }


        }
        if (Goodbool == true  && Player.GetComponent<GetNotes>().Hit == true)//Hit判定
        {
            Debug.Log("Hit");
            HPImage.GetComponent<Image>().fillAmount -= AttackPoint;
        }
        if(Goodbool == false && Player.GetComponent<GetNotes>().Destroyed == true)
        {
            Debug.Log("Miss");
            
        }
        

    }
}
