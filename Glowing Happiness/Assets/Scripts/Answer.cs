using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class Answer : MonoBehaviour, IRenderable
{
    private TextMeshProUGUI AnswerObject;
    public State state;

    public void Awake()
    {
        AnswerObject = GetComponentInChildren<TextMeshProUGUI>();
        state.observe(this);
    }

    public void render()
    {
        AnswerObject.text = state.getSelectedAnswer().text;
        gameObject.GetComponent<Button>().interactable = state.isAnswerActive();
    }

    public void OnClick()
    {
        state.selectAnswer();
    }
}
