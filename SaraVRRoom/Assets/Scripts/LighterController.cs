using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LighterController : MonoBehaviour
{
    public GameObject flame;

    public void ToggleFlame(bool on)
    {
        flame.SetActive(on);
    }
}

