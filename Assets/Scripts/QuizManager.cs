using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    // Start is called before the first frame update
    public List<QuestionAndAnswers> QnA;
    public GameObject[] options;
    public int CurrentQuestion = 0;

    public Text QuestionText;

    public GameObject quizPanel;
    public GameObject goPanel;
    void Start()
    {
        quizPanel.SetActive(true);
        goPanel.SetActive(false);
        generateQuestion();
    }

    void GameOver()
    {
        goPanel.SetActive(true);
        quizPanel.SetActive(false);
    }
    public void correct()
    {
        CurrentQuestion++;
        generateQuestion();

    }
    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<Image>().color = options[i].GetComponent<AnswerScript>().startColor;
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[CurrentQuestion].Answers[i];

            if (QnA[CurrentQuestion].CorrectAnswer == i + 1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        }
    }

    void generateQuestion()
    {
        if (CurrentQuestion < QnA.Count)
        {
            QuestionText.text = QnA[CurrentQuestion].Question;
            SetAnswers();
        }
        else
        {
            Debug.Log("Out of questions");
            GameOver();
        }
    }
}
