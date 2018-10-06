using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class Answer : MonoBehaviour {

    private Question Question;
    private TextMeshProUGUI AnswerObject;
    public string text;
    public string Reaction;
    public string Scene;
    public int ConfessionDelta;

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
    }


    public void OnClick()
    {
        if (buttonPressed == false)
        {
            UpdateConfessionMeter();
            React();
            AnswerObject.text = "Weiter";
            buttonPressed = true;
            Question.DeactivateNavigation();
        }
        else {
            SceneManager.LoadScene(Scene);
        }       
    }

    private void UpdateConfessionMeter() {
        int currentConfession = PlayerPrefs.GetInt("confession");
        PlayerPrefs.SetInt("confession", currentConfession + ConfessionDelta);
    }

    private void React() {
        Question.setText(Reaction);
    }

    
}
