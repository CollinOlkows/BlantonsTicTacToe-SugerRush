using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public void HoverOver(){
        GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
    }

    public void HoverEnd(){
        GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
