using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartTriggerScript : MonoBehaviour
{
    [SerializeField] private GameObject spikeHazzard;
    [SerializeField] private GameObject heart;
    private void OnTriggerEnter(Collider other)
    {
        spikeHazzard.SetActive(true);
        Destroy(heart);
    }
}
