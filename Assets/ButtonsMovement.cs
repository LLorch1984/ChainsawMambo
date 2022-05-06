using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsMovement : MonoBehaviour
{
    public ButtonManagement[] buttons;
    public int position = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            buttons[position].selected = false;
            
        }
        if (position == 0 )
        {
            Debug.Log("entro aqui");
            position++;
            buttons[position].selected = true;
        }
        else
        {
            Debug.Log("Entro aqui");
            position--;
            buttons[position].selected = true;
        }
    }
}
