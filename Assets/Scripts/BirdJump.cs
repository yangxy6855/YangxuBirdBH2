using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdJump : MonoBehaviour{

	private Rigidbody2D rigidbody2D;
	// Use this for initialization
	void Start (){
		rigidbody2D = GetComponent<Rigidbody2D>();
		//git test 222
	}

	public void AddForce(Vector2 force){
		rigidbody2D.AddForce(force);
	}
	
}
