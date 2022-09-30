using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


// if you click the character and it moves on its own do this: 

public class CharacterMovement : MonoBehaviour
{// **********update to move to tile**********
    bool selectCharTF = false;
    bool go = false;
    Vector3 newMousePos;
    Vector2 newMousePos2D;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && selectCharTF == true)
        {
            newMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            newMousePos2D = new Vector2(newMousePos.x, newMousePos.y);
            selectCharTF = false;
            go = true;
        }

        if ((Vector2)transform.position != newMousePos2D && go == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, newMousePos2D, Time.deltaTime * 10);
        }
        else
        {
            go = false;
        }

    }


    public void setCharacterSelectionTrue()
    {
        selectCharTF = true;
    }
    public void setCharacterSelectionFalse()
    {
        selectCharTF = false;
        Debug.Log(false);
    }
    public bool checkSelect()
    {
        return selectCharTF;
    }
}
