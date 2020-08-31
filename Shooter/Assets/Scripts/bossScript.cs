using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class bossScript : MonoBehaviour
{
   public Rigidbody2D enemy; 

	public float moveSpeed = 12.0f; // move speed of the enemy

	public bool changeDirection = false; //set the bool to false

	//public int lives = 5;

	public static int hits;


	// Use this for initialization
	void Start () {
		enemy = this.gameObject.GetComponent<Rigidbody2D>(); 
		hits = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		moveEnemy ();
	}

	public void moveEnemy()
	{
		
		if (changeDirection == true) {
			enemy.velocity = new Vector2 (1, 0) * -1 * moveSpeed; //get the enemy to move left
		} 
		else if (changeDirection == false) 
		{
			enemy.velocity = new Vector2 (1, 0) * moveSpeed; //get the enemy to move right
		}
	}

	

	void OnCollisionEnter2D(Collision2D col)
	{
		//change direction on hitting wall

		if (col.gameObject.name == "rightWall") 
		{
			Debug.Log ("Hit the right wall");
			changeDirection = true;
		}
		if (col.gameObject.name == "leftWall") 
		{
			Debug.Log ("Hit the left wall");
			changeDirection = false;
		}
		if (col.gameObject.tag == "enemy") 
		{

			//if collides with other enemy change direction
			Debug.Log ("Hit enemy");
			if (changeDirection == true) {

				changeDirection = false;
			} 
			else if (changeDirection == false) 
			{
				changeDirection = true;
			}
		}
		if (col.gameObject.tag == "Player") 
		{
			Player.health -= 0.2f;
			//if hits player reduce their heatlh and destroy enemy
			


		}
		if (col.gameObject.tag == "bullet") 
		{
			//if hits decrements lives
				hits++;


					if(hits > 4 )
						// if boss is out of lives give player points, and load next level
						ScoreScript.scoreValue += 500;
						level.levelValue ++;
						Spawn.killed = 0;
						Spawn.bosses --;
						//lives =5;
						Destroy(this.gameObject);

						LoadNextScene();

                }
		}
	
	public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
}
