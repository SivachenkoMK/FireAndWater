using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadLevelMenu()
    {
        SceneManager.LoadScene("LevelMenu");
    }

    public void LoadThisLevel()
    {
        GameController gameController = GameObject.Find("GameController").GetComponent<GameController>();
        SceneManager.LoadScene($"Level_{gameController.Level}");
    }
    public void LoadNextLevel()
    {
        GameController gameController = GameObject.Find("GameController").GetComponent<GameController>();
        SceneManager.LoadScene($"Level_{gameController.Level + 1}");
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level_1");
    }
    
    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level_2");
    }
    
    public void LoadLevel3()
    {
        SceneManager.LoadScene("Level_3");
    }

    public void LoadLobby()
    {
        SceneManager.LoadScene("Lobby");
    }

    
    

}
