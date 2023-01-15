using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

 //all code from this video https://www.youtube.com/watch?v=IvHqAzhIDSE&ab_channel=NotesFromANomad

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
