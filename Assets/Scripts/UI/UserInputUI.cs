using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class UserInputUI : MonoBehaviour
{
    private GameSceneManager gameSceneManager;

    [SerializeField]
    private TMP_InputField nicknameField;
    [SerializeField]
    private TMP_Dropdown suburbField;
    [SerializeField]
    private TMP_Dropdown ageField;


    private void Start()
    {
        gameSceneManager = GameObject.Find("SceneManager").GetComponent<GameSceneManager>();
        if (gameSceneManager == null)
        {
            Debug.LogError("GameSceneManager not found");
        }
    }


    private bool ValidateForm()
    {
        bool nicknameValid = false;
        bool suburbValid = false;
        bool ageValid = false;

        if (string.IsNullOrEmpty(nicknameField.text) == false)
        {
            nicknameValid = true;
        }
        if (suburbField.value == 0)
        {
            nicknameValid = true;
        }
        if (ageField.value == 0)
        {
            nicknameValid = true;
        }

        if (nicknameValid && suburbValid && ageValid)
        {
            return true;
        }
        Debug.LogError("You must fill out all fields");
        return false;
    }


    public void SubmitForm()
    {
        //if (ValidateForm())
        //{
            gameSceneManager.ChangeScene(2);
        //}
    }
}