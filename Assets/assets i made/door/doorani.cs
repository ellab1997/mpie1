using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorani : MonoBehaviour
{
    bool isActive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other){
        isActive = true;
        Animator anim = GetComponent<Animator>();
        anim.SetBool("go", isActive);
        
    }

    void OnTriggerExit(Collider other){
        isActive = false;
    }
}
