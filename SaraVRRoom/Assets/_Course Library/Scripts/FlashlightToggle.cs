using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightToggle : MonoBehaviour
{
    public Light flashlightLight;
    public AudioSource clickSound;

    public void Flip()
    {
        flashlightLight.enabled = !flashlightLight.enabled;
        clickSound.Play();
    }
}

