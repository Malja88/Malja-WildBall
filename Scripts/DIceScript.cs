using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DIceScript : MonoBehaviour
{
    [SerializeField] private GameObject dice;
    [SerializeField] private GameObject clueScreen;
    [SerializeField] private GameObject burst;
    private void OnTriggerEnter(Collider other)
    {
        clueScreen.SetActive(true);
        burst.SetActive(true);
        if (other.tag == "Player")
        {
            Destroy(dice);
        }
    }
}
