using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    public void OnClick()
    {

        PlayerPrefs.SetInt("confession", 0);
        SceneManager.LoadScene("Main");
    }
}
