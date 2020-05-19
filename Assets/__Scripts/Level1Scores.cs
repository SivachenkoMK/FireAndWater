using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Scores : MonoBehaviour, ILevelable
{
    [HideInInspector]
    public float CurrentTime;
    [HideInInspector]
    public float MaxScore;
    [HideInInspector]
    public float MinimalTime;
    [HideInInspector]
    public float CurrentScore;
    private float CountScore(float Time)
    {
        float Score = 1000 - Time * Time + 2 * Time - 1;
        if (Score < 0)
            return 0;
        return Score;
    }
    public void SetCurrentTime()
    {
        CurrentTime = this.gameObject.GetComponent<Timer>().TimeFromStart;
    }

    public void SetMaxScore()
    {
        if (CurrentScore > MaxScore)
            MaxScore = CurrentTime;
    }

    public void SetMinimalTime()
    {
        if (CurrentTime < MinimalTime)
            MinimalTime = CurrentTime;
    }

    public void SetCurrentScore()
    {
        CurrentScore = CountScore(CurrentTime);
    }
}
