using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Начальные позиции игроков.
    public Vector3 FirstPlayerPosition;
    public Vector3 SecondPlayerPosition;

    // Префабы отвечающие за игроков.
    public GameObject FirstPlayerPrefab;
    public GameObject SecondPlayerPrefab;

    // Объекты отвечающие за игроков. 
    private GameObject FirstPlayer;
    private GameObject SecondPlayer;

    // Префабы отвечающие за таблицы, появляющиеся после игры
    public GameObject LoseTablePrefab;
    public GameObject WinTablePrefab;

    // Объекты - таблички после игры
    private GameObject LoseTable;
    private GameObject WinTable;

    private void Awake()
    {
        FirstPlayer = Instantiate(FirstPlayerPrefab, FirstPlayerPosition, Quaternion.identity);
        SecondPlayer = Instantiate(SecondPlayer, SecondPlayerPosition, Quaternion.identity);
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void UnpauseGame()
    {
        Time.timeScale = 1;
    }

    public void EndGame()
    {
        if (FirstPlayer == null || SecondPlayer == null)
        {
            LoseGame();
        }
        else
        {
            WinGame();
        }
    }

    private void LoseGame()
    {
        DestroyAllPlayers();
        LoseTable = Instantiate(LoseTablePrefab, Vector3.zero, Quaternion.identity);
    }

    private void WinGame()
    {
        DestroyAllPlayers();
        WinTable = Instantiate(WinTablePrefab, Vector3.zero, Quaternion.identity);
    }

    private void DestroyAllPlayers()
    {
        if (FirstPlayer != null)
            Destroy(FirstPlayer);
        if (SecondPlayer != null)
            Destroy(SecondPlayer);
    }
}
