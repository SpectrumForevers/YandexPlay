using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GUIManager : MonoBehaviour
{
    [SerializeField] GameObject startText;
    [SerializeField] TMP_Text scoreText;
    int score;
    bool gameIsStarted = false;

    private void Update()
    {
        score = GameManager.Instance.GetScore();
        gameIsStarted = GameManager.Instance.GetStartGame();
        if (gameIsStarted)
        {
            startText.SetActive(false);
        }

        if (score > 0)
        {
            scoreText.text = score.ToString();
        }
    }
}
