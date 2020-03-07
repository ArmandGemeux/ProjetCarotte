using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ManagerBoutons : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GotoGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void GotoMenuScene()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void Doquit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
