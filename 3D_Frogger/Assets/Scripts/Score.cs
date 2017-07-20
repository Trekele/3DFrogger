using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public static int CurrentScore = 0;
    public static int Lifes = 3;
    public static float time = 30f;
    public Text textScore;
    public Text lifes;
    public Slider timer;
    
	void Start () {
               
        textScore.text = CurrentScore.ToString();
        lifes.text = Lifes.ToString();
        timer.maxValue = time;
	}

    private void Update()
    {
        textScore.text = CurrentScore.ToString();
        lifes.text = Lifes.ToString();
        if (time>0)
      {
            time -= Time.deltaTime;
            timer.value = time;
        }

        if(time<=0)
        {
            Lifes--;
            if (Lifes == 0)
            {
            //    Lifes = 3;
            //    CurrentScore = 0;
                SceneManager.LoadScene("GameOver");
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
           

        }
        


    }

}
