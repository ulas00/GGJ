using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Scene2story : MonoBehaviour
{
    public GameObject gameobject;
    public TMP_Text storyText;
    public AudioSource audio2;
    #region StoryTexts
    private string text1 = "Moray Bey'in lokanta zinciri çığ gibi büyümektedir. Nuray ile evlenir. Bu evlilikten nur gibi ikizleri Oray ve Koray doğar. ";
    private string text2 = "Moray Bey iyi niyetinden Eşber'i evlatlık edinir. Ona öz oğlu gibi bakar. Eşber Bey'in ona oyun oynadığından bihaberdir.";

    #endregion

    private void Start()
    {
        Time.timeScale = 0;
        storyText.text = text1;//giristeki hikaye
        
    }

    void Update()
    {       
            if (Input.GetKeyDown(KeyCode.Mouse0)) //cikis icin 
            {
            storyText.text = text2;
            audio2.Play();
            }
           if (Input.GetKeyDown(KeyCode.E))
            {
                Time.timeScale = 1;
                gameobject.SetActive(false);
            }
    }
}