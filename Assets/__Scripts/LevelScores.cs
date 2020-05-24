using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScores : MonoBehaviour
{
    public int CurrentLevel { get; set; }
    public float CurrentTime { get; private set; }
    public float MaximalScore { get; private set; }
    public float MinimalTime { get; private set; }
    public float CurrentScore { get; private set; }
    private float CountScore(float Time)
    {
        float Score = 1000 - Time * Time + 2 * Time - 1;
        if (Score < 0)
            return 0;
        return Score;
    }
    private void SetCurrentTime()
    {
        CurrentTime = this.gameObject.GetComponent<Timer>().TimeFromStart;
    }

    private void SetMaxScore()
    {
        if (CurrentScore > MinimalTime)
            MaximalScore = CurrentTime;
    }

    private void SetMinimalTime()
    {
        if (CurrentTime < MinimalTime)
            MinimalTime = CurrentTime;
    }

    private void SetCurrentScore()
    {
        CurrentScore = CountScore(CurrentTime);
    }

    private void SetCurrentHighlights()
    {
        SetCurrentTime();
        SetCurrentScore();
    }

    public void SetCurrentHidhlightsZero()
    {
        CurrentTime = 0;
        CurrentScore = 0;
    }

    private void SetBestHighlights()
    {
        SetMinimalTime();
        SetMaxScore();
    }

    public void SetAllHighlights()
    {
        SetCurrentHighlights();
        SetBestHighlights();
    }
}
