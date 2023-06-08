using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameScript : MonoBehaviour
{
    [SerializeField] private GameObject startScreen;
    [SerializeField] private GameObject levelScreen;
    [SerializeField] private GameObject finalScreen;
    private void Start()
    {
        startScreen.SetActive(true);
    }
    public void OnClick()
    {
        startScreen.SetActive(false);
        levelScreen.SetActive(true);
    }  
    public void startLevel1()
    {  
        levelScreen.SetActive(false);
    }

    public void startLevel2()
    {
        SceneManager.LoadScene(1);
    }
    public void startLevel3()
    {
        SceneManager.LoadScene(2);
    }
    public void startLevel4()
    {
        SceneManager.LoadScene(3);
    }
    public void restartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void mainMenu()
    {
        finalScreen.SetActive(false);
        SceneManager.LoadScene(0);
    }
}

