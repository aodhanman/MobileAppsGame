using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D projectile;

    // Start is called before the first frame update

    public float moveSpeed = 10.0f;
    void Start()
    {
        projectile = this.gameObject.GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        projectile.velocity = new Vector2 (0, 1) * moveSpeed;
    }

    void OnCollisionEnter2D(Collision2D hit) {
        
        if (hit.gameObject.tag == "enemy"){
            ScoreScript.scoreValue += 100;
            Spawn.killed ++;
            SoundManager.PlaySound("enemyHit");

           // hit.gameObject.SetActive  (false);
            Destroy(this.gameObject);
           
        }
        if (hit.gameObject.tag == "Boss"){

            SoundManager.PlaySound("enemyHit");

           // hit.gameObject.SetActive  (false);
           
        }
        if (hit.gameObject.name == "Top") 
		{
			Destroy(this.gameObject);
		}
    }

}
