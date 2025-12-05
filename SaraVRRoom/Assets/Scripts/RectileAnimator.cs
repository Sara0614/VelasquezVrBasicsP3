using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticleAnimator : MonoBehaviour
{
    public float rotationSpeed = 90f;
    public float scaleSpeed = 2f;
    public float scaleAmount = 0.1f;

    private Vector3 startScale;

    void Start()
    {
        startScale = transform.localScale;
    }

    void Update()
    {
        // Spin the reticle
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);

        // Pulse scale
        float scale = 1f + Mathf.Sin(Time.time * scaleSpeed) * scaleAmount;
        transform.localScale = startScale * scale;
    }
}

