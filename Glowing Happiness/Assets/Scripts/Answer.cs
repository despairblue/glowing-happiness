using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class Answer : MonoBehaviour
{

    private Question Question;
    private TextMeshProUGUI AnswerObject;
    public string text;
    public string Reaction;
    public string Scene;
    public int ConfessionDelta;
    public int ConfessionCondition = 0;

    private bool buttonPressed;


    public void Start()
    {
        Question = GetComponentInParent<Question>();
        AnswerObject = GetComponentInChildren<TextMeshProUGUI>();
        AnswerObject.text = text;
        buttonPressed = false;
        if (Scene == "")
        {
            gameObject.SetActive(false);
        }

        if ( PlayerPrefs.GetInt("confession") < ConfessionCondition)
        {
            gameObject.GetComponent<Button>().interactable = false;
        }
    }


    public void OnClick()
    {
        if (buttonPressed == false)
        {
            UpdateConfessionMeter();
            React();
            AnswerObject.text = "Continue";
            buttonPressed = true;
            Question.DeactivateBackward();
            Question.DeactivateForward();
        }
        else
        {
            SceneManager.LoadScene(Scene);
        }
    }

    private void UpdateConfessionMeter()
    {
        int currentConfession = PlayerPrefs.GetInt("confession");
        PlayerPrefs.SetInt("confession", currentConfession + ConfessionDelta);
    }

    private void React()
    {
        Question.setText(Reaction);
    }


}
