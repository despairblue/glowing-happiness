using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Question : MonoBehaviour
{

    private TextMeshProUGUI Text;
    public string question;
    public Answer[] answers;

    public int index;

    public void Start()
    {
        Text = GetComponentInChildren<TextMeshProUGUI>();
        setText(question);
        answers = GetComponentsInChildren<Answer>();
        setIndex(index);
        Debug.Log("hi");
        changeAnswer();

    }

    public void nextAnswer()
    {
        setIndex(index + 1);
    }

    public void previousAnswer()
    {
        setIndex(index - 1);
    }

    private bool checkIfFirstAnswer()
    {
        Debug.Log(index == 0);
        return index == 0;
    }

    private bool checkIfLastAnswer()
    {
        Debug.Log(index == answers.Length - 1);
        return index == answers.Length - 1;
    }

    private void setIndex(int index)
    {
        this.index = Mathf.Clamp(index, 0, answers.Length - 1);

        if (checkIfFirstAnswer())
        {
            DeactivateBackward();
        }
        else
        {
            ActivateBackward();
        }

        if (checkIfLastAnswer())
        {
            DeactivateForward();
        }
        else
        {
            ActivateForward();
        }

        changeAnswer();
    }

    public void DeactivateForward()
    {
        GetComponentInChildren<Forward>().gameObject.SetActive(false);
    }

    public void ActivateForward()
    {
        GetComponentInChildren<Forward>(true).gameObject.SetActive(true);
    }

    public void DeactivateBackward()
    {
        Debug.Log("deactivate backward");
        GetComponentInChildren<Backward>().gameObject.SetActive(false);
    }

    public void ActivateBackward()
    {
        Debug.Log("activate backward");
        GetComponentInChildren<Backward>(true).gameObject.SetActive(true);
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
