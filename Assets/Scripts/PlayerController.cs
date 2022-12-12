using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10;
    private float horizontalInput;
    private float verticalInput;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        transform.Rotate(Vector3.up, speed * Time.deltaTime * horizontalInput);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("coin"))
        {
            Destroy(other.gameObject);
        }
    }
}