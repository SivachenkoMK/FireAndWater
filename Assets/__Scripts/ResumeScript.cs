using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeScript : MonoBehaviour
{
    public GameObject Table;
    public void Resume()
    {
        Time.timeScale = 1;
        Destroy(Table);
    }
}
