using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clipboardtrigger : MonoBehaviour
{

    //All of this is my own code
    public GameObject pic;
    public GameObject trigger;
    bool ePressed;
    bool collided;
    // Start is called before the first frame update
    void Start()
    {
        pic.SetActive(false);
        ePressed = false;
        collided = false;
    }

    // Update is called once per frame
    void Update()
    {
        if((Input.GetKeyDown("e")) && (collided == true)){
            Debug.Log("E key was pressed.");
            ePressed = true;
            pic.SetActive(true);
        }

        if(Input.GetKeyUp("e")){
            ePressed = false;
        }
    }

    void OnTriggerEnter(Collider other){
        collided = true;

    }

    void OnTriggerExit(Collider other){
        pic.SetActive(false);
        ePressed = false;
        collided = false;

    }
}
