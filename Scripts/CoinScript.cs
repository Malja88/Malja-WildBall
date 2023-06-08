using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    [SerializeField] private GameObject coin;
    [SerializeField] private GameObject burst;
    private void OnTriggerEnter(Collider other)
    {
        burst.SetActive(true);
        if (other.tag == "Player")
        {
            Destroy(coin);
        }
    }
}
