using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin2script : MonoBehaviour
{
    [SerializeField] private GameObject coin;
    [SerializeField] private GameObject button;
    private void OnTriggerEnter(Collider other)
    {
        button.SetActive(true);
        Destroy(coin);
    }
}
