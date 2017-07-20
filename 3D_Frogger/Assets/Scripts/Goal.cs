using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

    public string nextLevel = "";

    private void OnTriggerEnter(Collider other)
    {
        Score.CurrentScore += 100;
        SceneManager.LoadScene(nextLevel);
    }
}
