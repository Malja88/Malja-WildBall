using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceWallsLevel3 : MonoBehaviour
{
    private Vector3 bounce = new Vector3(0, 0, 1);
    private sbyte Power = 3;
    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.GetComponent<Rigidbody>().AddForce(bounce * Power, ForceMode.Impulse);
    }
}
