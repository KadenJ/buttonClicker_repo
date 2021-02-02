using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    

    private int currentScore = 0;
    public Text txt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetButtonDown("Fire1"))
        {

            currentScore = currentScore += 1;
            //return;

            

            print(currentScore);


            //rotates button
            //button.transform.Rotate(0, 100 * Time.deltaTime, 0);

        }

        UpdateScore();
        

    }


    //changes cursor
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    void OnMouseEnter()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);


    }

    void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }

    void UpdateScore()
    {
        txt.text = currentScore.ToString();
    }

}

