using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
	public GameObject bullet; // bullet

	public Transform bulletSpawn; //enemy bullets

	public float nextFire = 1.0f;
	public float currentTime = 0.0f;

	// Use this for initialization
	void Start () {
		bulletSpawn = this.gameObject.transform;
	}
	
	// Update is called once per frame
	void Update () {
		enemyShoot ();
	}

	public void enemyShoot()
	{
		currentTime += Time.deltaTime;
		if (currentTime > nextFire) 
		{
			nextFire += currentTime;

			Instantiate (bullet, bulletSpawn.position, Quaternion.identity); //FIRE!

			nextFire -= currentTime;
			currentTime = 0.0f;
		}
	}
}
