using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public List<QuestionAndAnswers> IntQnA;
    private List<QuestionAndAnswers> QnA; 
    public GameObject[] options;
    public int currentQuestion;

    public GameObject QuestionPanel;
    public GameObject ScorePanel;

    public Text QuestionTxt;
    public Text ScoreTxt;

    int totalQuestions = 0;
    public int score;

    private FirebaseManager firebaseManager;

    private void Start()
    {
        QnA = new List<QuestionAndAnswers>(IntQnA);
        // QnA.AddRange(IntQnA);
        totalQuestions = QnA.Count;
        score = 0;
        generateQuestion();
        ScorePanel.SetActive(false);
        QuestionPanel.SetActive(true);
    }

    public void retry()
    {
        Start();
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void GameOver()
    {
        ScorePanel.SetActive(true);
        ScoreTxt.text = score + "/" + totalQuestions;
        QuestionPanel.SetActive(false);
        firebaseManager = GameObject.Find("FirebaseManager").GetComponent<FirebaseManager>();
        firebaseManager.SaveDataButton();
    }

    public void correct()
    {
        //when you are right
        score += 1;
        QnA.RemoveAt(currentQuestion);
        StartCoroutine(waitForNext());
    }

    public void wrong()
    {
        //when you answer wrong
        QnA.RemoveAt(currentQuestion);
        StartCoroutine(waitForNext());
    }

    IEnumerator waitForNext()
    {
        yield return new WaitForSeconds(1);
        generateQuestion();
    }

    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<Image>().color = options[i].GetComponent<AnswerScript>().startColor;
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];
            
            if(QnA[currentQuestion].CorrectAnswer == i+1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        }
    }

    void generateQuestion()
    {
        if(QnA.Count > 0)
        {
            currentQuestion = Random.Range(0, QnA.Count);

            QuestionTxt.text = QnA[currentQuestion].Question;
            SetAnswers();
        }
        else
        {
            Debug.Log("Out of Questions");
            GameOver();
        }


    }
}
