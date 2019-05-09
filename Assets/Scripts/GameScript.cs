using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

class Varior
{
    Image PersImage;

    int coordX;
    int coordY;

    bool isLive = true;

    double speed;
    double distanse;
    int hp;
    int power;
    int armor;
    int xp;

    void attack(Varior attacked)
    {
        attacked.protection(this.armor);
    }

    void protection(int armor)
    {
        xp -= Mathf.Max(0, power - armor);
        if(xp <= 0)
        {
            isLive = false;
        }

    }

}

class Group
{
    List<Varior>  gr = new List<Varior>();

    bool isVisible = true;

    GameObject fdg = new GameObject();
    

    void union(Group ug)
    {
        
        foreach(Varior v in ug.gr)
        {
            gr.Add(v);

            gr = null;
        }
        
    }
}

class Province
{
    string build = "";
    Image buildImage;



}

public class GameScript : MonoBehaviour
{
    public GameObject province;

    public GameObject Camera;

    public GameObject scene;

    public Texture2D imageKaz;

    public Texture2D imageRyd;

    List<Province> provList = new List<Province>();

    bool gg = false;
    float camSpeed = 50;
    float gold = 1000;


    public void sf()
    {
        gg = true;
        Debug.Log("OnPointerEnter called.");
    }




    // Start is called before the first frame update
    void Start()
    {

    }

    void OnGUI()
    {
        //Collider2D gg = province.GetComponents<Collider2D>()[0].;

        if (gg)
        {
            GUI.Box(new Rect(100, 0, 100, 100),"d" );
        }
        GUI.Box(new Rect(0, 0, 100, 100), "Gold: " + gold);
        if (GUI.Button(new Rect(100, 200, 100, 50), "Завершити хід"))
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


        
        Camera.transform.position += new Vector3(moveX * camSpeed, moveY * camSpeed, scrool * camSpeed);




    }
}
