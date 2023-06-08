using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuddleTriggerScript : MonoBehaviour
{
    [SerializeField] private GameObject puddle;
    private void OnTriggerEnter(Collider other)
    {
        puddle.SetActive(true);
    }
}
