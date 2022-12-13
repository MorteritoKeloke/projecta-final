using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour
{
    private float speed = 180;

    void Update()
    {
        transform.Rotate(speed * Time.deltaTime, 0, 0);
    }
}
