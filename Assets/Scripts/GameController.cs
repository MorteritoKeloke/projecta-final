using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
public float velocidad = 10;
Rigidbody bollaRigidBody;
    void Start()
    {
        bollaRigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horitzontal = Input.GetAxis("horitzontal");

        bollaRigidBody.AddForce(new Vector3(horitzontal,0,vertical) * velocidad);
    }
}
