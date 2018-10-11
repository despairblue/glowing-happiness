using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backward : MonoBehaviour, IRenderable
{
    public State state;
    public void Start()
    {
        state.observe(this);
    }

    public void render()
    {
        gameObject.SetActive(!state.isFirstAnswer());
    }

    public void OnClick()
    {
        Debug.Log("OnClick");
        state.previousAnswer();
    }


}
