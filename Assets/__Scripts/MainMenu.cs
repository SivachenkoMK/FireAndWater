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
    public void LoadLevel1()
    {
        SceneManager.LoadScene("Tanya1");
      
    }
    public void LoadLobby()
    {
        SceneManager.LoadScene("Lobby");
    }

    
    

}
