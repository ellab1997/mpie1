using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    public float ammoLevel = 0.0f;
    public AudioClip audioClip1;
    public AudioClip audioClip2;
    public AudioSource audioSouce1;
    public AudioSource audioSource2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.name == "AmmoBox"){
            other.gameObject.SetActive(false);
            ammoLevel += 20.0f;
            AudioSource audioClip2 = GetComponent<AudioSource>();
            audioClip2.Play();
   
            
        }

        if(ammoLevel == 0){
            if(other.gameObject.name == "AmmoBoxNew"){
                other.gameObject.SetActive(false);
                ammoLevel += 20.0f;

            }
        }
    }

    void FixedUpdate(){
        if(ammoLevel < 0){
            if(Input.GetButtonDown("Left")){
                Ray ray =  Camera.main.ViewportPointToRay(new Vector3(0.5f ,0.5f ,0.0f));
                RaycastHit result; 
                Physics.Raycast(ray, out result);
                GameObject g = result.collider.gameObject;
                ammoLevel -= 1;
                Animation a = g.transform.parent.GetComponent<Animation>();
                a.Play("LowerBridge");
            }

        } 
        if (Input.GetButtonDown("Left") && ammoLevel == 0) {
            AudioSource audioClip1 = GetComponent<AudioSource>();
            audioClip1.Play();
        }
    
    }
}
