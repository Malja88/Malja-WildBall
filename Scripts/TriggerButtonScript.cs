using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerButtonScript : MonoBehaviour
{
    [SerializeField] GameObject wall; 
    private void OnTriggerEnter(Collider other)
    {
        wall.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        wall.SetActive(false);
    }
}
