using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Web;
using UnityEditor.Rendering.LookDev;

public class SceneHandler : MonoBehaviour
{

    public TMP_InputField User;



    public void StartGame()
    {

        //store the entered user name before the game starts
        setUsername();

        //Debug.Log("Start Game");
        SceneManager.LoadScene(1);
        
        
    }

    public void EndGame()
    {

        //Debug.Log("End Game");
        SceneManager.LoadScene(0);
    }





    private void setUsername()
    {
        //get the Username from the TMP Input field set in the SceneHandler inspector
        string username = User.text;

        //if no username is entered, make the user's name Anonymous
        if (username == "")
        {
            username = "Anonymous";
        }


        //set the username in the persistent manager
        PersistentManager.instance.Username = username;
    }
}
