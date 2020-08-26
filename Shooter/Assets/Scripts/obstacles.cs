using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacles : MonoBehaviour
{
        public Rigidbody2D obstacle; 

    // Start is called before the first frame update
    void Start()
    {
        obstacle = this.gameObject.GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col)
	{
        if (col.gameObject.tag == "Player") 
		{
			Player.health -= 0.1f;
			//if hits player reduce their heatlh and destroy obstacle
				Destroy(this.gameObject);
		} if (col.gameObject.name == "Bottom") 
		{
			
				Destroy(this.gameObject);
		}if (col.gameObject.tag == "bullet") 
		{
                ScoreScript.scoreValue += 10;
				Destroy(this.gameObject);
		}
    }
}
