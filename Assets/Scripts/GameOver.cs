using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{    
    void Start()
    {
        if (Data.score == 31)
        {
            SceneManager.LoadScene("Congratulations");
        }
    }

    public void ButtonReply()
    {
        SceneManager.LoadScene("Gameplay");     
    }

}
