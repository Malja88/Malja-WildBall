using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScriptLevel4 : MonoBehaviour
{
    private Vector3 bomb = new Vector3(0.5f, 1, 0);
    private int force = 5;
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Rigidbody>().AddForce(bomb * force, ForceMode.Impulse);
    }

}
