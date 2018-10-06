using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backward : MonoBehaviour {

    private Question question;

    public void Start()
    {
        question = GetComponentInParent<Question>();
    }

    public void onClick()
    {
        question.index -= 1;
        if (question.index < 1)
        {
            question.index = 0;
            this.enabled = false;
        }
        else {
            this.enabled = true;
        }
        question.changeAnswer();
    }
}
