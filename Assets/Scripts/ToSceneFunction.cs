using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToSceneFunction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MenuToGame1()
    {
        SceneManager.LoadScene("SampleScene 1");
    }
    public void GameToMenu()
    {
        SceneManager.LoadScene("StertGame");
    }
    public void MenuToGame2()
    {
        SceneManager.LoadScene("SampleScene 2");
    }

    public void MenuToGame3()
    {
        SceneManager.LoadScene("SampleScene 3");
    }
}
