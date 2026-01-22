using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallBounceSound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip bounceSound;

    void OnCollisionEnter(Collision collision)
    {
        audioSource.PlayOneShot(bounceSound);
    }
}

