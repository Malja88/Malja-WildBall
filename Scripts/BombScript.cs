using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour
{
    private Vector3 bomb = new Vector3(0, 1, 0);
    private int force = 25;
    [SerializeField] private GameObject GameOver;
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Rigidbody>().AddForce(bomb * force, ForceMode.Impulse);
        StartCoroutine(BombBlast());
    }
    private IEnumerator BombBlast()
    {
        yield return new WaitForSeconds(2);
        GameOver.SetActive(true);
    }
}
