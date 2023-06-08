using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin3Script : MonoBehaviour
{
    [SerializeField] private GameObject coin2;
    [SerializeField] private GameObject door2;
    private void OnTriggerEnter(Collider other)
    {
        door2.SetActive(false);
        Destroy(coin2);
    }
}
