using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    [SerializeField] Transform player;
    void Update()
    {
        transform.position = player.position;
    }
}
