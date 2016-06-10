﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed;
	private Rigidbody rb;
	void Start(){
		rb=GetComponent<Rigidbody>();
	}
	//físicas
	void FixedUpdate()
	{
		//Ctrl+' para ver la referencia de la función
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement=new Vector3(moveHorizontal,0.0f,moveVertical);
		
		rb.AddForce(movement*speed);
	}

}
