using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClueScreenScript : MonoBehaviour
{
    [SerializeField] private GameObject ClueScreen;
    [SerializeField] private GameObject trigger;
    private void OnTriggerEnter(Collider other)
    {
        ClueScreen.SetActive(true);
        StartCoroutine(DestroyClueScreen());
    }
    private IEnumerator DestroyClueScreen()
    {
        yield return new WaitForSeconds(3); 
        ClueScreen.SetActive(false);
        Destroy(trigger);
    }
}
