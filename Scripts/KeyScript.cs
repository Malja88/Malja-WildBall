using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    [SerializeField] private GameObject key;
    [SerializeField] private GameObject clueScreen;
    [SerializeField] private GameObject keyBurst;
    private void OnTriggerEnter(Collider other)
    {
        keyBurst.SetActive(true);
        clueScreen.SetActive(true);    
        if (other.tag == "Player")
        {
            Destroy(key);
        }
    }
}
