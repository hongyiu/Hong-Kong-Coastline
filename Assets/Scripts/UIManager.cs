using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    //Screen object variables
    [Header("Game Panel")]
    public GameObject MapPanel;
    public GameObject QuizPanel;

    public GameObject AuthPanel;
    public GameObject loginUI;
    public GameObject registerUI;

    [Header("Game Object")]
    public GameObject scoreSavedMessage;
    public GameObject QuizAuthButton;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Debug.Log("Instance already exists, destroying object!");
            Destroy(this);
        }
    }

    //Functions to change to Quiz Panel
    public void StartQuiz() //Start Quiz
    {
        scoreSavedMessage.SetActive(false);
        QuizPanel.SetActive(true);
        MapPanel.SetActive(false);
    }
    public void QuitQuiz() //Finish Quiz
    {
        MapPanel.SetActive(true);
        QuizPanel.SetActive(false);
    }

    public void StartAuth() 
    {
        AuthPanel.SetActive(true);
    }
    public void QuitAuth() //start Auth
    {
        AuthPanel.SetActive(false);
    }
    //Functions to change the login screen UI
    public void LoginScreen() //Back button
    {
        loginUI.SetActive(true);
        registerUI.SetActive(false);
    }
    public void RegisterScreen() // Regester button
    {
        loginUI.SetActive(false);
        registerUI.SetActive(true);
    }

    public void EnableScoreSavedMessage()
    {
        Debug.Log("Set scoreSavedMessage to true");
        scoreSavedMessage.SetActive(true);
    }

    public void DisableQuizAuthButton()
    {
        Debug.Log("Set QuizAuthButton to false");
        QuizAuthButton.SetActive(false);
    }
}