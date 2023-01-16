using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menubuttons : MonoBehaviour
{
    AudioSource clink;
 //All of this code is taken from a tutorial and Unity documentation
 //From: https://www.youtube.com/watch?v=-GWjA6dixV4&ab_channel=BMo and https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.LoadScene.html
 //Accessed 16/02/23

    void Start(){
        clink = GetComponent<AudioSource>();
    }

    void Update(){
        
    }
    public void startGame(){
        SceneManager.LoadScene ("ye", LoadSceneMode.Single);
        clink.Play();
    }

    public void quitGame(){
        Application.Quit();
        clink.Play();
    }
   
    
}
