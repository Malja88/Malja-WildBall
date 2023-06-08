using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingStoneScript : MonoBehaviour
{
    [SerializeField] private GameObject board1;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(board1);
    }

}
