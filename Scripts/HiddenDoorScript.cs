using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenDoorScript : MonoBehaviour
{
    [SerializeField] private GameObject Door;
    private void OnTriggerEnter(Collider other)
    {
        Door.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        Door.SetActive(false);
    }
}
