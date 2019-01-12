using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{
    public void Game()
    {
        SceneManager.LoadScene(1);
    }
    public void MM()
    {
        SceneManager.LoadScene(0);
    }
    
}
