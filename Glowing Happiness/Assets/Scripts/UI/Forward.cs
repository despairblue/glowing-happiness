using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forward : MonoBehaviour, IRenderable
{
    public State state;
    public void Start()
    {
        state.observe(this);
    }

    public void render()
    {
        gameObject.SetActive(!state.isLastAnswer());
    }

    public void OnClick()
    {
        state.nextAnswer();
    }


}
