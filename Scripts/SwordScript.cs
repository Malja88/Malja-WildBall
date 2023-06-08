using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordScript : MonoBehaviour
{
    [SerializeField] private GameObject sword;
    private void OnTriggerEnter(Collider other)
    {
        sword.SetActive(true); 
    }
    private void OnTriggerExit(Collider other)
    {
        sword.SetActive(false);
    }
}
