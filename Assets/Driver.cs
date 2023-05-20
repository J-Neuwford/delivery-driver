using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    [SerializeField] float turnSpeed = 0.5f;
    [SerializeField] float moveSpeed = 0.01f;
    void Start()
    {

    }

    void Update()
    {
        float turnAmount = Input.GetAxis("Horizontal") * turnSpeed;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed;

        transform.Rotate(0, 0, -turnAmount);
        transform.Translate(0, moveAmount, 0);
    }
}