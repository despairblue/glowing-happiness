using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Question : MonoBehaviour
{

    private TextMeshProUGUI Text;
    public string question;
    public Answer[] answers;

    public int index;

    public void Start()
    {
        index = 0;
        Text = GetComponentInChildren<TextMeshProUGUI>();
        setText(question);
        answers = GetComponentsInChildren<Answer>();
        changeAnswer();
    }

    public void DeactivateNavigation()
    {
        GetComponentInChildren<Forward>().gameObject.SetActive(false);
        GetComponentInChildren<Backward>().gameObject.SetActive(false);
    }

    public void setText(string text)
    {
        Text.text = text;
    }

    public void changeAnswer()
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
