using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Question : MonoBehaviour {

    private TextMeshProUGUI Text;
    public string question;

    public void Start()
    {
        Text = GetComponentInChildren<TextMeshProUGUI>();
        setText(question);
    }

    public void setText(string text) {
        Text.text = text;
    }

}
