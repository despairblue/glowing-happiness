using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IRenderable
{
    void render();
}

public class State : MonoBehaviour
{
    public Scene scene;
    public int confessionMeter = 0;

    private int selectedAnswerIndex = 0;
    private List<IRenderable> renderables = new List<IRenderable>();

    public void Awake()
    {
        scene = GetComponentInChildren<Scene>();
    }

    public void Start()
    {
        renderObservers();
    }

    public void observe(IRenderable renderable)
    {
        renderables.Add(renderable);
    }

    public void unobserve(IRenderable renderable)
    {
        renderables.Remove(renderable);
    }

    public void nextAnswer()
    {
        setSelectedAnswer(selectedAnswerIndex + 1);
    }

    public void previousAnswer()
    {
        setSelectedAnswer(selectedAnswerIndex - 1);
    }

    public AnswerState getSelectedAnswer()
    {
        return scene.answers[selectedAnswerIndex];
    }

    public bool isAnswerActive()
    {
        return confessionMeter >= getSelectedAnswer().confessionCondition;
    }

    public void selectAnswer()
    {
        confessionMeter = confessionMeter + getSelectedAnswer().confessionDelta;
        nextScene();
    }

    public bool isFirstAnswer()
    {
        return selectedAnswerIndex == 0;
    }

    public bool isLastAnswer()
    {
        return selectedAnswerIndex == scene.answers.Length - 1;
    }

    private void renderObservers()
    {
        foreach (var renderable in renderables)
        {
            renderable.render();
        }
    }

    private void nextScene()
    {
        var selectedAnswer = getSelectedAnswer();
        var nextScene = selectedAnswer.getReactionScene();
        if (nextScene)
        {
            scene = nextScene;
        }
        else
        {
            scene = GameObject.Find(selectedAnswer.nextScene).GetComponent<Scene>();
        }
        selectedAnswerIndex = 0;
        renderObservers();
    }

    private void setSelectedAnswer(int index)
    {
        this.selectedAnswerIndex = Mathf.Clamp(index, 0, scene.answers.Length - 1);
        renderObservers();
    }
}
