using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonHandler : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject cardBtn;
    public Animation animationObj;
    public string[] animationNames;
    private int currentAnimation = 0;


    public void Start()
    {
        cardBtn = GameObject.Find("eye_and_parts_btn");
        cardBtn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        //eyeAnim.GetComponent<Animator>();
        Debug.Log("############# Btn handler registered");
    }

    // Update is called once per frame
    public void Update()
    {
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb){
        Debug.Log("###########Playing animation index " + currentAnimation);
        animationObj.Play(this.animationNames[currentAnimation++]);
        currentAnimation = currentAnimation % animationNames.Length;
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb) {
        //animationObj.Play(this.animationNames[currentAnimation++]);
        //currentAnimation = currentAnimation % animationNames.Length;
    }
}
