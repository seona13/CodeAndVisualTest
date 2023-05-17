using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class UserInputUI : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField nicknameField;
    [SerializeField]
    private TMP_Dropdown suburbField;
    [SerializeField]
    private TMP_Dropdown ageField;

    [SerializeField]
    private GameObject errorPanel;
    [SerializeField]
    private TMP_Text nicknameError;
    [SerializeField]
    private TMP_Text suburbError;
    [SerializeField]
    private TMP_Text ageError;


    private void OnEnable()
    {
        CloseErrorPanel();
    }


    public void CloseErrorPanel()
    {
        nicknameError.gameObject.SetActive(false);
        suburbError.gameObject.SetActive(false);
        ageError.gameObject.SetActive(false);
        errorPanel.gameObject.SetActive(false);
    }


    private void OpenErrorPanel()
    {
        errorPanel.gameObject.SetActive(true);
    }


    private bool ValidateForm()
    {
        bool nicknameValid = false;
        bool ageValid = false;

        if (string.IsNullOrEmpty(nicknameField.text) == false)
        {
            nicknameValid = true;
        }
        else
        {
            nicknameError.gameObject.SetActive(true);
        }
        if (ageField.value != 0)
        {
            ageValid = true;
        }
        else
        {
            ageError.gameObject.SetActive(true);
        }

        if (nicknameValid && ageValid)
        {
            return true;
        }

        OpenErrorPanel();
        return false;
    }


    public void SubmitForm()
    {
        if (ValidateForm())
        {
            GameSceneManager.Instance.ChangeScene(2);
        }
    }
}