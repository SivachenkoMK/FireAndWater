using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameController : MonoBehaviour
{
    private bool IsEnded = false;

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
    public GameObject PauseTablePrefab;

    // Объекты - таблички после игры
    private GameObject LoseTable;
    private GameObject WinTable;
    private GameObject PauseTable;

    // Объекты - двери для персонажей.
    public GameObject FirstPlayerDoor;
    public GameObject SecondPlayerDoor;

    // Теги игроков
    private string FirstPlayerTag;
    private string SecondPlayerTag;

    public int Level;

    private void Awake()
    {
        FirstPlayer = Instantiate(FirstPlayerPrefab, FirstPlayerPosition, Quaternion.identity);
        SecondPlayer = Instantiate(SecondPlayerPrefab, SecondPlayerPosition, Quaternion.identity);
        FirstPlayerTag = FirstPlayer.tag;
        SecondPlayerTag = SecondPlayer.tag;
    }

    public void PauseGame()
    {
        PauseTable = Instantiate(PauseTablePrefab, Vector3.zero, Quaternion.identity);
        Time.timeScale = 0;
    }

    public void UnpauseGame()
    {
        Destroy(PauseTable);
        Time.timeScale = 1;
    }

    public void EndGame()
    {
        if (SomeoneDied())
        {
            LoseGame();
        }
        else if (AllDoorsAreOpened())
        {
            WinGame();
        }
    }

    private bool SomeoneDied()
    {
        if (FirstPlayerDied() || SecondPlayerDied())
            return true;
        return false;
    }

    private bool FirstPlayerDied()
    {
        if (GameObject.FindGameObjectWithTag(FirstPlayerTag) == null)
            return true;
        return false;
    }

    private bool SecondPlayerDied()
    {
        if (GameObject.FindGameObjectWithTag(SecondPlayerTag) == null)
            return true;
        return false;
    }

    private bool AllDoorsAreOpened()
    {
        if (FirstPlayerDoor.GetComponent<DoorScript>().IsOpened && SecondPlayerDoor.GetComponent<DoorScript>().IsOpened)
            return true;
        return false;
    }

    private void LoseGame()
    {
        IsEnded = true;
        DestroyAllPlayers();
        LoseTable = Instantiate(LoseTablePrefab, Vector3.zero, Quaternion.identity);
    }

    private void WinGame()
    {
        IsEnded = true;
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

    private void Update()
    {
        if (!IsEnded)
            EndGame();
    }
}
