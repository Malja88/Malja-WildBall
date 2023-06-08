using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyWall : MonoBehaviour
{
    private Vector3 bounce = new Vector3(1,0,1);    
    private sbyte Power = 5;
    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.GetComponent<Rigidbody>().AddForce(bounce * Power, ForceMode.Impulse);
    }
}
