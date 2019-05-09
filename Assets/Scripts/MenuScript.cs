using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public GameObject menoObject;
    public GameObject scene;
    

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnStartClick()
    {
        
        Application.LoadLevel(1);
    

    }

    public void OnExitClick()
    {
        
        Application.Quit ();

    }

}
