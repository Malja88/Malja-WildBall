using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private void OnParticleCollision(GameObject other)
    {
        player.SetActive(false);
    }
}
