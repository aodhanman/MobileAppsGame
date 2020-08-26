﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject enemy;
    float randX;
    float randY;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawn){
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-16.5f, 16.5f);
            randY = Random.Range(11f, 5f);
            whereToSpawn = new Vector2(randX, randY);
            Instantiate ( enemy, whereToSpawn, Quaternion.identity);

            
        }
    }
}
