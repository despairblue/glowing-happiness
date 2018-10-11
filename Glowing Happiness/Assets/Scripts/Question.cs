using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Question : MonoBehaviour, IRenderable
{

    private TextMeshProUGUI text;

    public State state;

    public void Awake()
    {
        text = GetComponentInChildren<TextMeshProUGUI>();
        state.observe(this);
    }

    public void render()
    {
        text.text = state.scene.question;
    }
}
