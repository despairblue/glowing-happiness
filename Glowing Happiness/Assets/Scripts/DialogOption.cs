using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class DialogOption : MonoBehaviour {

    public TextMeshProUGUI Text;
    public string scene;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onClick() {
        SceneManager.LoadScene(scene);
    }
}
