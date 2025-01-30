using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonHandler : MonoBehaviour
{   
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
        click.Play();
        }
    }
    public AudioSource click;
    //ass
    public void StartButtonClick()
    {
        SceneManager.LoadScene(1);   
    }

    public void QuitButtonClick()
    {
        Application.Quit();
    }
}
