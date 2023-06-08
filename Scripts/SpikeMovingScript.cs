using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeMovingScript : MonoBehaviour
{
    [SerializeField] Transform point;
    [SerializeField] GameObject GameOver;
    [SerializeField] private GameObject playerDeath;
    [SerializeField] private GameObject player;
    private Vector3 spike;
    void Start()
    {
        spike = point.position;
    }
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, spike, 0.01f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        player.SetActive(false);
        playerDeath.SetActive(true);
        StartCoroutine(death());
    }
    private IEnumerator death()
    {
        yield return new WaitForSeconds(2);
        GameOver.SetActive(true);
    }
}
