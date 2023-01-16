using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

 //All of this code is from a tutorial 
 //From: https://www.youtube.com/watch?v=IvHqAzhIDSE&ab_channel=NotesFromANomad
 //Accessed 16/01/23

public class texttriggernotdestroy : MonoBehaviour
{
    public GameObject textobject;
    public GameObject trigger;
    // Start is called before the first frame update
    void Start()
    {
        textobject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        textobject.SetActive(true);
    }

    void OnTriggerExit(Collider other){
        textobject.SetActive(false);

    }
}
