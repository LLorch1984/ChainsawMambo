using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManagement : MonoBehaviour
{
    
   
    public Color[] colors;
    public Image buttonImage;
    public bool selected = false;
    void Start()
    {
        buttonImage = GetComponent<Image>();
        buttonImage.color = colors[0];
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(selected)
        {
            buttonImage.color = colors[0];
        }
        else
        {
            Debug.Log("voy a poner el color chungele");
            Debug.Log(colors[1]);
            buttonImage.color = colors[1];
        }
        if( Input.GetKey(KeyCode.UpArrow) && selected)
        {
            Debug.Log("Aqui Entro");
            SceneManager.LoadScene("Level1");
        }
    }
}
