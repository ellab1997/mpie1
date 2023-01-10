using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menubuttons : MonoBehaviour
{
 //used unity documentation for this
    public void startGame(){
        SceneManager.LoadScene ("ye", LoadSceneMode.Single);
    }
   
    
}
