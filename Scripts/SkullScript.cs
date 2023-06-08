using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullScript : MonoBehaviour
{
    [SerializeField] private GameObject skull;
    [SerializeField] private GameObject skullBurst;
    private void OnTriggerEnter(Collider other)
    {
        skull.SetActive(true);
        skullBurst.SetActive(true);
    }
}
