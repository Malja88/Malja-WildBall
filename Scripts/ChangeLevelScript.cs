using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevelScript : MonoBehaviour
{
    [SerializeField] private int LevelNumber;
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(LevelNumber);
    }
}
