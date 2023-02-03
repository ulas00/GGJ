using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button pbutton;
    public Button ebutton;
    void Start()
    {
        pbutton.onClick.AddListener(() => startgame());
        ebutton.onClick.AddListener(() => exitgame());
        
    }

    
    void Update()
    {
        
    }
    public void startgame()
    {
        SceneManager.LoadScene("SoyAgaci");
    }

    public void exitgame()
    {
        Application.Quit(); 
    }




}
