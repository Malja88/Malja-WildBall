using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScriptLevel4 : MonoBehaviour
{
    [SerializeField] private GameObject key;
    [SerializeField] private GameObject keyBurst;
    private void OnTriggerEnter(Collider other)
    {
        keyBurst.SetActive(true);
        if (other.tag == "Player")
        {
            Destroy(key);
        }
    }
}
