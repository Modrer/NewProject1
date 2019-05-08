using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript : MonoBehaviour
{
    public GameObject Camera;
   
    
    float camSpeed = 50;
    float gold = 1000;







    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnGUI()
    {
        GUI.Box(new Rect(0, 0, 100, 100), "Gold: " + gold);
        if(GUI.Button(new Rect(400,400,100,50), "Завершити хід"))
        {
            //endOfHod
        }
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        float scrool = Input.GetAxis("Mouse ScrollWheel");


        gold += moveX + moveY;
        Camera.transform.position += new Vector3(moveX * camSpeed, moveY * camSpeed , scrool*camSpeed);
        
       

        
    }

}
