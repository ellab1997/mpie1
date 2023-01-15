using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class planttirgger : MonoBehaviour
{
    public GameObject text;
    public GameObject trigger;
    bool ePressed;
    bool collided;
    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(false);
        ePressed = false;
        collided = false;
    }

    // Update is called once per frame
    void Update()
    {
        if((Input.GetKeyDown("e")) && (collided == true)){
            Debug.Log("E key was pressed.");
            ePressed = true;
            text.SetActive(true);
        }

        if(Input.GetKeyUp("e")){
            ePressed = false;
        }

    }

    void OnTriggerEnter(Collider other){
        collided = true;

    }

    void OnTriggerExit(Collider other){
        ePressed = false;
        text.SetActive(false);
        collided = false;

    }
}
