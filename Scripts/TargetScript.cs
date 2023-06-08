using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    private Animator anim;
    private Vector3 wallSpring = new Vector3(0, 1, 1);
    private sbyte force = 4;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        anim.SetTrigger("Target");
        other.gameObject.GetComponent<Rigidbody>().AddForce(wallSpring * force, ForceMode.Impulse);
    }
    private void OnTriggerExit(Collider other)
    {
        anim.SetTrigger("Target2");
    }
}
