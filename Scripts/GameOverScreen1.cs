using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreen1 : MonoBehaviour
{
    [SerializeField] private GameObject gameOver;
    [SerializeField] private GameObject playerDeath;
    [SerializeField] private GameObject player;
    private void OnCollisionEnter(Collision collision)
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
