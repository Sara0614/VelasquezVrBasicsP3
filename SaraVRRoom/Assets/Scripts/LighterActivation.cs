using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LighterActivation : MonoBehaviour
{
    public GameObject flame;
    private XRGrabInteractable grab;

    void Start()
    {
        grab = GetComponent<XRGrabInteractable>();
        grab.activated.AddListener(TurnOnFlame);
        grab.deactivated.AddListener(TurnOffFlame);
    }

    void TurnOnFlame(ActivateEventArgs args)
    {
        flame.SetActive(true);
    }

    void TurnOffFlame(DeactivateEventArgs args)
    {
        flame.SetActive(false);
    }
}

