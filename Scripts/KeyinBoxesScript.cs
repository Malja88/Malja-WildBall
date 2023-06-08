using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyinBoxesScript : MonoBehaviour
{
    [SerializeField] private GameObject keyInBoxes;
    [SerializeField] private GameObject WoodenDoor;
    private void OnTriggerEnter(Collider other)
    {
        WoodenDoor.SetActive(false);
        Destroy(keyInBoxes);
    }
}
