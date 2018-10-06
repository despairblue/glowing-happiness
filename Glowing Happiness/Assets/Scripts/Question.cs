using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Question : MonoBehaviour
{

    private TextMeshProUGUI Text;
    public string question;
    public Answer[] answers;

    private int index;

    public void Start()
    {
        index = 0;
        Text = GetComponentInChildren<TextMeshProUGUI>();
        setText(question);
        answers = GetComponentsInChildren<Answer>();
        changeAnswer();
    }
    

    public void Forward()
    {
        index += 1;
        if (answers.Length <= index) {
            index = 0;
        }
        changeAnswer();
    }

    public void Backward()
    {
        index -= 1;
        if (index < 0) {
            index = answers.Length - 1;
        }
        changeAnswer();
    }

    public void setText(string text)
    {
        Text.text = text;
    }

    private void changeAnswer()
    {
        for (int i = 0; i < answers.Length; i++)
        {
            if (i == index)
            {
                answers[i].gameObject.SetActive(true);
            }
            else
            {
                answers[i].gameObject.SetActive(false);
            }
        }
    }

}
