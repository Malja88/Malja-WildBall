using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScreenScript : MonoBehaviour
{
    [SerializeField] private GameObject winScreen;
    private void OnTriggerEnter(Collider other)
    {
        winScreen.SetActive(true);
    }
}
