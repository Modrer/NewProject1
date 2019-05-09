using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TestScript : EventTrigger
{
    // Start is called before the first frame update
    void Start()
    {
        
    }



    public override void OnPointerEnter(PointerEventData data)
    {
        Debug.Log("OnPointerEnter called.");
    }
    public void sf()
    {
        Debug.Log("OnPointerEnter called.");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
