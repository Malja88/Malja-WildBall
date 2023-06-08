using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxExplosionScript : MonoBehaviour
{
    private float Power = 15;
    private sbyte Radius = 2;
    [SerializeField] private GameObject boxes;
    [SerializeField] private GameObject key;
    [SerializeField] private GameObject box6;
    void Start()
    {
        Explosion();
        Destroy(box6);
        StartCoroutine(keyreveal());
    }

    void Explosion()
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
    private IEnumerator keyreveal()
    {
        yield return new WaitForSeconds(0.16f);
        key.SetActive(true);   
    }
}
