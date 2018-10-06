using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backward : MonoBehaviour
{

    private Question question;

    public void Start()
    {
        question = GetComponentInParent<Question>();
    }

    public void OnClick()
    {
        Debug.Log("clicked");
        question.previousAnswer();
    }

    
}