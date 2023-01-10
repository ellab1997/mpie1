using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menubuttons : MonoBehaviour
{
 
    public void startGame(){
        SceneManager.LoadScene ("ye", LoadSceneMode.Single);
    }

    public void loadControls(){
       
    }
   
    
}
