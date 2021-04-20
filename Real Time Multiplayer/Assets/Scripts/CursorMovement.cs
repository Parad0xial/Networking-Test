using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CursorMovement : MonoBehaviour
{   


    void Update()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = cursorPos;

        if ("Game" == SceneManager.GetActiveScene().name)
        { 
            Cursor.visible = false;
        } else {
            Cursor.visible = true;  
		}
    }
}
