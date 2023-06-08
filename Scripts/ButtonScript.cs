using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    [SerializeField] private GameObject boomTrigger;
    private void OnCollisionEnter(Collision collision)
    {
        boomTrigger.SetActive(true);
    }
}
