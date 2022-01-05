using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BrickSpawner : MonoBehaviour
{
    //public variables
    public GameObject brickPrefab;
    //public static bool flagB = true;

    //private variables
    float time = 0f;
    float minSpawnTime = 2f, maxSpawnTime = 10f;
    

    // Start is called before the first frame update
    void Start()
    {
        time = Random.Range(minSpawnTime, maxSpawnTime);    
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.flag == true){
            time -= Time.deltaTime;
            if (time <= 0 )
            {
                //instantiate (spawn) brick
                Instantiate(brickPrefab, transform.position, Quaternion.identity);
                // set the next time for brick spawn
                time = Random.Range(minSpawnTime, maxSpawnTime);
            }
        } else
        {
            return;
        }
        
    }
}
