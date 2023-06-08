using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirSpikeScript : MonoBehaviour
{
    [SerializeField] private GameObject gameOver;
    [SerializeField] private GameObject playerDeath;
    [SerializeField] private GameObject player;
    private void OnTriggerEnter(Collider other)
    {
        player.SetActive(false);
        playerDeath.SetActive(true);
        StartCoroutine(death());
    }
    private IEnumerator death()
    {
        yield return new WaitForSeconds(2);
        gameOver.SetActive(true);
    }
}
