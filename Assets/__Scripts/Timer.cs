using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text TimerText;
    public float TimeFromStart;
    private void Update()
    {
        TimeFromStart += Time.deltaTime;
        TimerText.text = TimeFromStart.ToString().Split(',')[0];
    }
}
