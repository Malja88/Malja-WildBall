using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingWallScript : MonoBehaviour
{
    [SerializeField] private GameObject block;
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            block.SetActive(true);
        }
    }
}
