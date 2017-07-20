using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Frog : MonoBehaviour
{
    public Camera[] cameras = new Camera[2];
    public Rigidbody rb;
    public AudioSource audioSource;
    public AudioClip[] audioClips = new AudioClip[2];
    private bool changeClip = true;
    private int toggle = 0;

    void Update()
    {
        if(changeClip)
            audioSource.clip = audioClips[0];

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            StartCoroutine(Jump());
            this.gameObject.transform.eulerAngles = new Vector3(0, 90, 0);
            rb.MovePosition(rb.position + Vector3.right);
            audioSource.Play();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            StartCoroutine(Jump());
            this.gameObject.transform.eulerAngles = new Vector3(0, -90, 0);
            rb.MovePosition(rb.position + Vector3.left);
            audioSource.Play();
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            StartCoroutine(Jump());
            this.gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
            rb.MovePosition(rb.position + Vector3.forward);
            audioSource.Play();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            StartCoroutine(Jump());
            this.gameObject.transform.eulerAngles = new Vector3(0, 180, 0);
            rb.MovePosition(rb.position + Vector3.back);
            audioSource.Play();
        }
        else if(Input.GetKeyDown(KeyCode.C))
        {
            if(toggle==0)
            {
                cameras[0].enabled = false;
                cameras[1].enabled = true;
                toggle = 1;
            }
            else
            {
                cameras[0].enabled = true;
                cameras[1].enabled = false;
                toggle = 0;
            }
        }
        
        
    }

    public void hit()
    {             
            Score.Lifes--;           
            StartCoroutine(death());       
        
    }


    IEnumerator death()
    {
        changeClip = false;
        audioSource.clip = audioClips[1];
        audioSource.Play();
        Score.CurrentScore = 0;
        Score.time = Score.rememberTime;
        yield return new WaitForSeconds(.4f);
        if (Score.Lifes <= 0)
        {
            SceneManager.LoadScene("TitleScreen");
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private IEnumerator Jump()
    {
        int i = 0;
        while(i<6)
        {
            this.gameObject.transform.Translate(0, .05f, 0);
            i++;
            yield return new WaitForFixedUpdate();
        }       

        yield return null;
    }

}
