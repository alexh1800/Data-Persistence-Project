using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void StartGame()
    {

        //Debug.Log("Start Game");
        SceneManager.LoadScene(1);
    }

    public void EndGame()
    {

        //Debug.Log("End Game");
        SceneManager.LoadScene(0);
    }
}
