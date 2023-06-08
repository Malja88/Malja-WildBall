using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CeilingSPikeScript : MonoBehaviour
{
    [SerializeField] private GameObject gameOver;
    [SerializeField] private GameObject playerDeath;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject ceilingSpikes;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            player.SetActive(false);
            playerDeath.SetActive(true);
            StartCoroutine(death());
        }
    }
    private IEnumerator death()
    {
        yield return new WaitForSeconds(0.5f);
        gameOver.SetActive(true);
        yield return new WaitForSeconds(1);
        Destroy(ceilingSpikes);
    }
}
