using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//code from https://www.youtube.com/watch?v=guelZvubWFY&ab_channel=GameDevTraum


public class entertext : MonoBehaviour
{
    bool activateGoodAnimation;
    bool activateBadAnimation;
    private string input;
    // Start is called before the first frame update
    void Start()
    {
        activateGoodAnimation = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(activateGoodAnimation == true){
            Animator anim = GetComponent<Animator>();
            anim.SetBool("", activateGoodAnimation);
        }

        if(activateBadAnimation == true){
            Animator anim = GetComponent<Animator>();
            anim.SetBool("", activateBadAnimation);
        }
    }

    public void textInput(string newText){
        input = newText;
        Debug.Log(input);
        input.ToLower();
        if(input == "i love you" || input == "be strong" || input == "you're amazing" || input == "youre amazing" || input == "grow well" || input == "stay healthy"){
            activateGoodAnimation = true;
        } else {
            activateBadAnimation = true; 
        }
    }
}
