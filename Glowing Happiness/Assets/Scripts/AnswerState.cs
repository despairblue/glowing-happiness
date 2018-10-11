using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class AnswerState : MonoBehaviour
{

    public string text = "";
    public string reaction = "";
    public string nextScene = "";
    public int confessionDelta = 0;
    public int confessionCondition = -100;

    public Scene getReactionScene()
    {
        if (reaction.Length > 0)
        {
            var answer = gameObject.AddComponent<AnswerState>();
            answer.nextScene = nextScene;
            answer.text = "...";
            var scene = gameObject.AddComponent<Scene>();
            scene.question = reaction;
            scene.answers = new AnswerState[] { answer };
            return scene;
        }
        return null;
    }
}
