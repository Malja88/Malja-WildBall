using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenButtonScript : MonoBehaviour
{
    [SerializeField] private GameObject bridge;
    private void OnTriggerEnter(Collider other)
    {
        bridge.SetActive(true);
    }
}
