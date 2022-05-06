using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartButton()
    {
        Debug.Log("me entero");
        SceneManager.LoadScene("Level1");
    }

    // Update is called once per frame
    public void QuitButton()
    {
        Debug.Log("me entero");
        Application.Quit();
    }
}
