using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnVelocityy : MonoBehaviour
{
    public GameObject flame;
    public float shakeThreshold = 2.5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (rb.velocity.magnitude > shakeThreshold)
        {
            flame.SetActive(false);
        }
    }
}

