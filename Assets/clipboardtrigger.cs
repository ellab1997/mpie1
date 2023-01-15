using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clipboardtrigger : MonoBehaviour
{
    public GameObject pic;
    public GameObject trigger;
    // Start is called before the first frame update
    void Start()
    {
        pic.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        if(Input.GetKeyDown(KeyCode.E)){
            Debug.Log("E key was pressed.");
            pic.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other){
        pic.SetActive(false);

    }
}
