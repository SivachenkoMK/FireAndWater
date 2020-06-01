using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public bool IsEnded;
    public Text TimerText;
    public float TimeFromStart = 0;
    private void Update()
    {
        if (!IsEnded)
        TimeFromStart += Time.deltaTime;
        TimerText.text = TimeFromStart.ToString().Split(',')[0];
    }
}
