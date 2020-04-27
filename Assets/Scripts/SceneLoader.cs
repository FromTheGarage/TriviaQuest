using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.SceneManagement; //This namespace allows you to move between scenes

public class SceneLoader : MonoBehaviour
{


    //This method is attached to each button in every scene except the End Game Results Scene. It advances the user to the next Question (Scene)
    public void loadNextQuestion()
    {

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex; //From SceneManager class, run GetActiveScene method, return build index (scene we're currently on)
        SceneManager.LoadScene(currentSceneIndex + 1);

    }



    //Attached to Play Again button in End Game Results Scene. Returns user to Start Menu
    public void loadStartScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(0); //Go back to the starting scene (0th index)


    }

    
     
  



}
