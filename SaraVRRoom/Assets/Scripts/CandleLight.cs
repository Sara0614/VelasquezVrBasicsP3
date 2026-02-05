using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleLight : MonoBehaviour
{
    public GameObject candleFlame;
    private bool isLit = false;

    void Start()
    {
        candleFlame.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Flame") && !isLit)
        {
            candleFlame.SetActive(true);
            isLit = true;
        }
    }
}
