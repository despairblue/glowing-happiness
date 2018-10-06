using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forward : MonoBehaviour {

    private Question question;

    public void Start()
    {
        question = GetComponentInParent<Question>();
    }

    public void OnClick()
    {
        question.nextAnswer();
    }

    
}
