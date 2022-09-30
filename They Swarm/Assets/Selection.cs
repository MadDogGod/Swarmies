using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selection : MonoBehaviour
{//************need to update to able to select the tile*********
    Vector2 mousePos2D;
    Vector3 mousePos;
    RaycastHit2D hit;

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos2D = new Vector2(mousePos.x, mousePos.y);

            hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit && hit.collider.CompareTag("PlayerCharacters"))
            {
                hit.collider.GetComponent<CharacterMovement>().setCharacterSelectionTrue();
                Debug.Log(hit.collider.name);
            }
            else if (hit)
            {
                hit.collider.GetComponent<CharacterMovement>().setCharacterSelectionFalse();
            }


        }
    }
}
