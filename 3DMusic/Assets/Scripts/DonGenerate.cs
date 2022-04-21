using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonGenerate : MonoBehaviour
{
    public Don DonPrefab;
    
    public float Spawn;
    private float seconds;
    public float MaxXPos;
    public float MinXPos;
    // prefab‚ÆInstantiate
    //healDon‚Ìƒ‚ƒm
    public GameObject healDon;
    public float healSpawn;
    private float healseconds;
    public float healMaxXPos;
    public float healMinXPos;
    private void Start()
    {
        
    }
    void Update()
    {
        seconds += Time.deltaTime;
        healseconds += Time.deltaTime;
        if (Spawn < seconds )
        {
            Spwan();
            seconds = 0;
        }
        if(healSpawn < healseconds)
        {
            HealSpawn();
            healseconds = 0;
        }
    }
    public void Spwan()
    {
        float x = Random.Range(MinXPos, MaxXPos);
        Instantiate(DonPrefab, new Vector3(x, 1, 5), Quaternion.identity); // Quaternion.identity‚Í‰Šú’l

    }
    public void HealSpawn()
    {
        float x = Random.Range(healMinXPos, healMaxXPos);
        Instantiate(healDon, new Vector3(x, 1, 5), Quaternion.identity);
    }
}
