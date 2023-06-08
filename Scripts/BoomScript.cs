using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomScript : MonoBehaviour
{
    private float Power = 7;
    private sbyte Radius = 1;
    [SerializeField] private GameObject rockPile;
    private void Start()
    {
        Boom();
        StartCoroutine(removeRocks());
    }
    void Boom()
    {
        Rigidbody[] blocks = FindObjectsOfType<Rigidbody>();

        foreach (Rigidbody B in blocks)
        {
            if (Vector3.Distance(transform.position, B.transform.position) < Radius)
            {
                Vector3 direction = B.transform.position - transform.position;

                B.AddForce(direction.normalized * Power * (Radius - Vector3.Distance(transform.position, B.transform.position)), ForceMode.Impulse);
            }
        }

    }
    private IEnumerator removeRocks()
    {
        yield return new WaitForSeconds(3);
        Destroy(rockPile);
    }
}
