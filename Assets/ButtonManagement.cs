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
            buttonImage.color = colors[1];
        }
        else
        {
            buttonImage.color = colors[0];
        }
        if( Input.GetKey(KeyCode.KeypadEnter) && selected)
        {
            SceneManager.LoadScene("Level1", LoadSceneMode.Single);
        }
    }
}
