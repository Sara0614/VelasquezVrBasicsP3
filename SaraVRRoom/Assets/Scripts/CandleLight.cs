using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleLight : MonoBehaviour
{
    public GameObject candleFlame;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("TRIGGER HIT BY: " + other.gameObject.name);
        candleFlame.SetActive(true);
    }
}


