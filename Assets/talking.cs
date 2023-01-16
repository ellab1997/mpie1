using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 //All code fis from a tutorial 
 //From: https://www.youtube.com/watch?v=IvHqAzhIDSE&ab_channel=NotesFromANomad
 //Accessed: 16/01/23

public class talking : MonoBehaviour
{
    public GameObject textobject1;
    public GameObject textobject2;
    public GameObject textobject3;
    public GameObject trigger;
    bool isActive;
    // Start is called before the first frame update
    void Start()
    {
        textobject1.SetActive(false);
        textobject2.SetActive(false);
        textobject3.SetActive(false);
        isActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        Animator anim = GetComponent<Animator>();
        anim.SetBool("talking", isActive);
        
    }
    void OnTriggerEnter(Collider other){
        textobject1.SetActive(true);
        textobject2.SetActive(true);
        textobject3.SetActive(true);
        isActive = true;
    }

    void OnTriggerExit(Collider other){
        textobject1.SetActive(false);
        textobject2.SetActive(false);
        textobject3.SetActive(false);
        isActive = false;
    }
}
