using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target2Script : MonoBehaviour
{
    private Vector3 wallSpring = new Vector3(0, 1, -1);
    private sbyte force = 5;
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Rigidbody>().AddForce(wallSpring * force, ForceMode.Impulse);
    }

}
