using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeScript : MonoBehaviour
{
    [SerializeField] GameObject spikeObject;

    private void OnTriggerEnter(Collider other)
    {
        spikeObject.SetActive(true);
    }

}
