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


    public void Start()
    {
        Question = GetComponentInParent<Question>();
        AnswerObject = GetComponentInChildren<TextMeshProUGUI>();
        AnswerObject.text = text;
        if (Scene == "")
        {
            gameObject.SetActive(false);
        }
    }


    public void OnClick()
    {
        UpdateConfessionMeter();
        React();
        //Wait for Player Input
        SceneManager.LoadScene(Scene);
    }

    private void UpdateConfessionMeter() {
        int currentConfession = PlayerPrefs.GetInt("confession");
        PlayerPrefs.SetInt("confession", currentConfession + ConfessionDelta);
    }

    private void React() {
        Question.setText(Reaction);
    }

    
}
