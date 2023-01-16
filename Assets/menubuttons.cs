using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menubuttons : MonoBehaviour
{
    AudioSource clink;
 //used unity documentation for this and some of this video for help https://www.youtube.com/watch?v=-GWjA6dixV4&ab_channel=BMo

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
