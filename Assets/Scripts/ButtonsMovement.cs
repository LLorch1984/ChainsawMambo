using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsMovement : MonoBehaviour
{
    public ButtonManagement[] buttons;
    public int position = 0;
    void Start()
    {
        buttons[position].selected = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log(buttons[0].selected);
            Debug.Log(buttons[1].selected);
           
            buttons[position].selected = false;
           
            
        if (position == 0 )
        {
        
            position++;
            Debug.Log(position);
            buttons[position].selected = true;
        }
        else
        {
            position--;
            Debug.Log(position);
            buttons[position].selected = true;
        }
        }
        
    } 
}
