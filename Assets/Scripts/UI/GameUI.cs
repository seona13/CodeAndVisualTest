using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameUI : MonoBehaviour
{
    public event Action OnGameStart;

    private GameSceneManager gameSceneManager;

    [SerializeField]
    private Image overlay;
    [SerializeField]
    private TMP_Text scoreText;
    [SerializeField]
    private Image contamFill;

    private int score;
    private int maxScore;
    private float contamination;


    private void Start()
    {
        //gameSceneManager = GameObject.Find("SceneManager").GetComponent<GameSceneManager>();
        //if (gameSceneManager == null)
        //{
        //    Debug.LogError("GameSceneManager not found");
        //}

        GameManager.Instance.OnGameInit += GameManager_OnGameInit;
    }


    private void OnDisable()
    {
        GameManager.Instance.OnGameInit -= GameManager_OnGameInit;
    }


    private void GameManager_OnGameInit(int maxScore, int score, float contamination)
    {
        this.maxScore = maxScore;
        this.score = score;
        this.contamination = contamination;

        SetScoreText();
        SetContaminationFill();
    }


    public void BackToMenu()
    {
        gameSceneManager.ChangeScene(0);
    }


    public void StartGame()
    {
        overlay.gameObject.SetActive(false);
        OnGameStart?.Invoke();
    }


    private void SetScoreText()
    {
        scoreText.text = score + " / " + maxScore;
    }


    private void SetContaminationFill()
    {
        contamFill.fillAmount = contamination;
    }


    private void UpdateScore(int newScore)
    {
        score = newScore;
        SetScoreText();
    }


    private void UpdateContamination(float newContam)
    {
        contamination = newContam;
        SetContaminationFill();
    }
}