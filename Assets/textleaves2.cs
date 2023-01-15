using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//text input code from https://www.youtube.com/watch?v=guelZvubWFY&ab_channel=GameDevTraum


public class entertext : MonoBehaviour
{
    bool activateGoodAnimation;
    bool activateBadAnimation;
    private string input;
    public GameObject textBox;

    // Start is called before the first frame update
    void Start()
    {
        activateGoodAnimation = false;
        activateBadAnimation = false;

    }

    // Update is called once per frame
    void Update()
    {
        //keep track of how many they've done so far correctly
        if(activateGoodAnimation == true){
            GameObject parentGood = transform.parent.gameObject;
            Animator anim = parentGood.GetComponent<Animator>();
            anim.SetBool("second", activateGoodAnimation);
            anim.Play("2");
        } 

        if(activateBadAnimation == true){
            GameObject parentBad = transform.parent.gameObject;
            Animator anim = parentBad.GetComponent<Animator>();
            anim.SetBool("", activateBadAnimation);
        }

    }
//this from tutorial
    public void textInput(string newText){
        input = newText;
//to this
        Debug.Log(input);
        input.ToLower();
        if(input == "i love you" || input == "be strong" || input == "you're amazing" || input == "youre amazing" || input == "grow well" || input == "stay healthy"){
            activateGoodAnimation = true;
            Debug.Log(activateGoodAnimation);
            Destroy(textBox);
        } else if (input == "i hate you" || input == "be weak" || input == "you're awful" || input == "youre awful" || input == "grow badly" || input == "be unhealthy") {
            activateBadAnimation = true; 
            Debug.Log(activateBadAnimation);
        } else {

        }
    }
}
