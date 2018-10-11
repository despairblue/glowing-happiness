using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfessionUI : MonoBehaviour, IRenderable
{

    public State state;
    private Slider slider;

    public void Start()
    {
        slider = GetComponent<Slider>();
        state.observe(this);
    }

    public void render()
    {
        slider.value = PlayerPrefs.GetInt("confession");
    }
}
