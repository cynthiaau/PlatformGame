﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheEnemy : MonoBehaviour {

	// Use this for initialization

	public bool movRight = false; //checks if the enemy moves right or left
	public float movSpeed = 2.5f; //movement of the enemy
	public float rightBound = 16.0f; //how far to the right to go
	public float leftBound = 8.0f; //how far to the left to go

	void Start () {
		
	}

	
	// Update is called once per frame
	void Update () {
		//enemy will move to the right
		if (movRight)
		{
			transform.Translate(Vector2.right * movSpeed * Time.deltaTime);
		}

		//enemy will move to the left
		else
		{
			transform.Translate(Vector2.left * movSpeed * Time.deltaTime);
		}

		//enemy moves left until reaching leftboundary
		if (transform.position.x >= rightBound) 
		{
			Flip();
			//movRight = false;
		}
		
		//enemy moves right until reaching rightboundary
		if (transform.position.x < leftBound)
		{
			Flip();
			//movRight = true;
		}
	}

	public void Die()
	{
		//object will destroy itself
		Destroy(gameObject);
	}

	void Flip()
    {
        movRight = !movRight;

        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }
}
