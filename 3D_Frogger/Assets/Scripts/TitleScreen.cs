using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleScreen : MonoBehaviour {

    public Slider slider;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void playAgain()
    {
        Score.CurrentScore = 0;

        switch(slider.value.ToString())
        { 
            case "0":
                Score.Lifes = 3;
                Score.time = 60f;
                Score.rememberTime = Score.time;
                break;

            case "1":
                Score.Lifes = 2;
                Score.time = 40f;
                Score.rememberTime = Score.time;
                break;

            case "2":
                Score.Lifes = 1;
                Score.time = 20f;
                Score.rememberTime = Score.time;
                break;

        }

       

        SceneManager.LoadScene("3DFrogger");
    }
}
