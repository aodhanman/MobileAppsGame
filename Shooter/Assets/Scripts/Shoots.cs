using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoots : MonoBehaviour
{public GameObject projectile; 

	public Transform projectileSpawn;

	public float nextFire = 1.0f; //time  between shots
	public float currentTime = 0.0f; //current time 

	
	void Start () {
		projectileSpawn = this.gameObject.transform; 
	}
	
	// Update is called once per frame
	void Update () {
		
		shoot (); 
	}

	//shooting functionality to ship
	public void shoot()
	{
		currentTime += Time.deltaTime; //timer
		if(Input.GetButton("Fire1") && currentTime > nextFire) 
		{
			nextFire += currentTime; 

			SoundManager.PlaySound("shot");
			Instantiate (projectile,projectileSpawn.position, Quaternion.identity);

			nextFire -= currentTime; 
			currentTime = 0.0f; //reset current time
		}
	}
}