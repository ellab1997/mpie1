using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reset : MonoBehaviour
{
    //all my own code and I used the unity documentation for it
    //https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.LoadScene.html
    bool resetPressed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        resetTrue(); 
       if(resetPressed == true)
        SceneManager.LoadScene ("menu", LoadSceneMode.Single);
    }
    void resetTrue(){
        bool resetButton = Input.GetAxis("reset") > 0.0f;
        if(resetButton == true){
            resetPressed = true;
        } 

    }
}
