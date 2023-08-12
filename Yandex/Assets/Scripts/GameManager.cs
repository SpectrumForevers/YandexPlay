using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] GameObject textForStart;
    private int score;
    bool gameIsStarted = false;
    private void Awake()
    {
        Instance = this;
        Time.timeScale = 0f;
    }
    private void Update()
    {
        CheckStartGame();
    }
    private void CheckStartGame()
    {
        if (textForStart != null)
        {
            if (textForStart.activeInHierarchy)
            {
                if (Input.GetKey(KeyCode.Space))
                {
                    Time.timeScale = 1f;
                    gameIsStarted = true;
                }
            }
        }
    }
    public void SetScore(int scoreAdd)
    {
        score += scoreAdd;
    }
    public bool GetStartGame()
    {
        return gameIsStarted;
    }
    public int GetScore()
    {
        return score;
    }
}
