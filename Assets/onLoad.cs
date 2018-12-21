using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var eyeAnim = GameObject.Find("eye parts animation").GetComponent<Animation>();
        eyeAnim.Play("contract");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
