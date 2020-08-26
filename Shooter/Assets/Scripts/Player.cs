using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   public float moveSpeed = 10.0f;

    public Rigidbody2D player;

    public static float health;


    // Start is called before the first frame update
    void Start()
    {
        health = 1.0f;
        player = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovePlayer();
    }

    public void MovePlayer(){
        player.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * moveSpeed;
    }
}
