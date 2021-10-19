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

    private void Start()
    {
        
    }
    void Update()
    {
        seconds += Time.deltaTime;

        if(Spawn < seconds )
        {
            Spwan();
            seconds = 0;
        }
    }
    public void Spwan()
    {
        float x = Random.Range(MinXPos, MaxXPos);
        Instantiate(DonPrefab, new Vector3(x, 1, 5), Quaternion.identity); // Quaternion.identity‚Í‰Šú’l

    }
}
