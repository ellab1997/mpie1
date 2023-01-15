using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//text input code from https://www.youtube.com/watch?v=guelZvubWFY&ab_channel=GameDevTraum


public class textleaves3 : MonoBehaviour
{
    bool activateGoodAnimation;
    bool activateBadAnimation;
    private string input;
    public GameObject textBox;
    public GameObject mainObject;

    // Start is called before the first frame update
    void Start()
    {
        activateGoodAnimation = false;
        activateBadAnimation = false;
        mainObject.SetActive(false);
        textBox.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        if(activateGoodAnimation == true){
            mainObject.SetActive(true);
            Animator anim = GetComponent<Animator>();
            anim.SetBool("third", activateGoodAnimation);
            anim.Play("Take 001");
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
            Destroy(textBox);
        } else if (input == "i hate you" || input == "be weak" || input == "you're awful" || input == "youre awful" || input == "grow badly" || input == "be unhealthy") {
            activateBadAnimation = true; 
        } else {

        }
    }
    
}



