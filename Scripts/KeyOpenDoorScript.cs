using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyOpenDoorScript : MonoBehaviour
{
    [SerializeField] private GameObject key;
    [SerializeField] private GameObject keyBurst;
    [SerializeField] private GameObject Door;    
    private void OnTriggerEnter(Collider other)
    {
        keyBurst.SetActive(true);
        Door.SetActive(false);
        Destroy(key);
    }
}
