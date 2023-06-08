using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpringScript : MonoBehaviour
{
    private Vector3 wallSpring = new Vector3(0,0,1);
    private sbyte force = 15;
    [SerializeField] private GameObject door;
    [SerializeField] private GameObject spikes;
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Rigidbody>().AddForce(wallSpring * force, ForceMode.Impulse);
        door.SetActive(false);
        spikes.SetActive(true);
    }
}
