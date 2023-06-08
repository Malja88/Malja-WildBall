using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalDoorScript : MonoBehaviour
{
    [SerializeField] private GameObject finalDoor;
    [SerializeField] private GameObject fireworks;
    [SerializeField] private GameObject finalScreen;
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            finalDoor.SetActive(false);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        fireworks.SetActive(true);
        StartCoroutine(final());
    }

    private IEnumerator final()
    {
        yield return new WaitForSeconds(4);
        finalScreen.SetActive(true);
    }

}
