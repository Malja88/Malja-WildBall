using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterScript : MonoBehaviour
{
    [SerializeField] private GameObject GameOver;
    private void OnTriggerEnter(Collider other)
    {
        GameOver.SetActive(true);
    }
}
