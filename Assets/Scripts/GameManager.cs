using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;


public class GameManager : MonoSingleton<GameManager>
{
    public event Action<int, int, float> OnGameInit;
    public event Action<int> OnScoreChanged;
    public event Action<float> OnContaminationChanged;
    public event Action OnGameOver;

    [SerializeField]
    private GameUI gameUI;
    [SerializeField]
    private int maxScore;

    private bool gameRunning;
    private int score;
    private float contamination;


    private void OnEnable()
    {
        gameRunning = false;

        score = 0;
        contamination = 0;

        OnGameInit?.Invoke(maxScore, score, contamination);

        gameUI.OnGameStart += GameUI_OnGameStart;
    }


    private void OnDisable()
    {
        gameUI.OnGameStart -= GameUI_OnGameStart;
    }


    private void GameUI_OnGameStart()
    {
        gameRunning = true;
    }
}