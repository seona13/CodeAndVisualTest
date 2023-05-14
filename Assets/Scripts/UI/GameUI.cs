using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameUI : MonoBehaviour
{
    private GameSceneManager gameSceneManager;


    private void Start()
    {
        gameSceneManager = GameObject.Find("SceneManager").GetComponent<GameSceneManager>();
        if (gameSceneManager == null)
        {
            Debug.LogError("GameSceneManager not found");
        }
    }


    public void BackToMenu()
    {
        gameSceneManager.ChangeScene(0);
    }
}