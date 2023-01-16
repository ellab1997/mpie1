using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorani : MonoBehaviour
{
    //All of this is my own code
    bool isActive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isActive == true){
            Animator anim = GetComponent<Animator>();
            anim.SetBool("go", isActive);
        }
    }

    void OnTriggerEnter(Collider other){
        isActive = true;
        
    }

    void OnTriggerExit(Collider other){
        isActive = false;
    }
}
