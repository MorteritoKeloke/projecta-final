using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //the player speed
    public float speed = 20;
    //the camera rotation speed
    public float turnSpeed = 100;
    private float horizontalInput;
    private float verticalInput;
    private int coins = 0;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //how the ball moves
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("coin"))
        {
            //the coin disappears when you touch it
            Destroy(other.gameObject);
            //when you take a coin the counter adds 1
            coins = coins + 1;
            Debug.Log($"Congratulations you have taken {coins} coins!!!");
        }
    }
}