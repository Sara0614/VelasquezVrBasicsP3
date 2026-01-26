using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleWick : MonoBehaviour
{
    public GameObject candleFlame;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fire"))
        {
            candleFlame.SetActive(true);
        }
    }
}

