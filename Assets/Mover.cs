using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
	[SerializeField] float moveSpeed = 7;
	float x, y, z;

	void Start()
	{
		
	}

	void Update()
	{
		x = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
		z = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
		transform.Translate(x,y,z);
	}

	void PrintInstructions()
	{
		Debug.Log("Use the arrow keys to move the cube.");
	}
}
