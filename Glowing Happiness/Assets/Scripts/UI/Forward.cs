using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forward : MonoBehaviour {

    private Question question;

    public void Start()
    {
        question = GetComponentInParent<Question>();
    }

    public void onClick()
    {
        question.index += 1;
        if (question.index > question.answers.Length -1)
        {
            question.index = question.answers.Length - 1;
            this.enabled = false;
        }
        else
        {
            this.enabled = true;
        }
        question.changeAnswer();
    }
}
