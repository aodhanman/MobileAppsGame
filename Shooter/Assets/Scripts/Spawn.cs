using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject enemy;
    public GameObject obstacle;
    float randX;
    float randY;
    float randX2;
    float randY2;

    public static int killed = 0;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;
    float nextObstacle = 0.0f;
    public float obstacleSpawn = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawn){

            //spawns enemies at random loaction in range
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-16.2f, 16.2f);
            randY = Random.Range(11f, 5f);
            whereToSpawn = new Vector2(randX, randY);
            Instantiate ( enemy, whereToSpawn, Quaternion.identity);

            
            
        }if(Time.time > nextObstacle){

            //spawns obstacles
            nextObstacle = Time.time + obstacleSpawn;
            randX2 = Random.Range(-16.2f, 16.2f);
            randY2 = Random.Range(14.6f, 11.8f);
            whereToSpawn = new Vector2(randX2, randY2);
        Instantiate ( obstacle, whereToSpawn, Quaternion.identity);
        }
        

    }
}
