using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene : MonoBehaviour
{
    public string question;

    public AnswerState[] answers;

    void Awake()
    {
        answers = GetComponentsInChildren<AnswerState>();
    }

}
