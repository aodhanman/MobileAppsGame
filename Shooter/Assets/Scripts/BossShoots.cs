﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossShoots : MonoBehaviour
{
   
    public Rigidbody2D projectile; 

    public float moveSpeed = 10.0f;

    
    // Start is called before the first frame update
    void Start()
    {
        projectile = this.gameObject.GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        projectile.velocity = new Vector2(0, -1) * moveSpeed;
    }
     void OnCollisionEnter2D(Collision2D hit) {
        
        //when it hits the player
		if (hit.gameObject.tag == "Player") 
		{
            Player.health -= 0.2f;
            			SoundManager.PlaySound("playerHit");

            Destroy(this.gameObject);
			//hit.gameObject.SetActive (false);
		}
		//when it hits the bottom of the screen
		if (hit.gameObject.name == "Bottom") 
		{
			Destroy(this.gameObject);
		}if (hit.gameObject.tag == "enemy") 
		{
			//Destroy(this.gameObject);
		}
	}
}
