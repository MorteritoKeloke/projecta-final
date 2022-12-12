using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
	private Rigidbody rb;
	[Range(1, 10)]
	public float velocidad = 5;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate()
	{
		float movimientoH = Input.GetAxis("Horizontal");
		float movimientoV = Input.GetAxis("Vertical");

		Vector3 movimiento = new Vector3(movimientoH * velocidad, 0.0f, movimientoV * velocidad);

		rb.AddForce(movimiento);
	}
}